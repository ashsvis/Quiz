using MySql.Data.MySqlClient;

namespace QuizModel
{
    public delegate void GetReaded(object[] values);

    public sealed class ServerSQL : IDisposable
    {
        private readonly string connectionString = string.Empty;
        private static string lasterrorString = string.Empty;
        public MySqlConnection myConnection;
        private bool serverConnected = false;
        private string databaseName = string.Empty;

        public static string LastError { get { return lasterrorString; } }

        public ServerSQL(string connectionString, string? database = null)
        {
            this.connectionString = connectionString;
            if (!string.IsNullOrWhiteSpace(database))
                connectionString += "database=" + database + ";";
            myConnection = new MySqlConnection(connectionString);
            serverConnected = TryToConnect();
        }

        public void Dispose()
        {
            myConnection.Dispose();
        }

        private bool TryToConnect()
        {
            try
            {
                // произведем попытку подключения
                myConnection.Open();
                lasterrorString = string.Empty;
                return true;
            }
            catch (Exception e)
            {
                lasterrorString = e.Message;
                return false;
            }
        }

        public bool Connected
        {
            get
            {
                return serverConnected;
            }
        }

        public string CurrentDatabase { get { return databaseName; } }

        /// <summary>
        /// Обертка для выполнения команды без возврата значения
        /// </summary>
        /// <param name="SQL">оператор команды</param>
        /// <param name="columns">параметры</param>
        /// <returns></returns>
        public bool ExecSQL(string SQL, Dictionary<string, object>? columns = null)
        {
            using MySqlCommand command = new(SQL, myConnection);
            try
            {
                if (columns != null)
                {
                    foreach (var key in columns.Keys)
                        command.Parameters.AddWithValue($"@{key}", columns[key]);
                }
                command.ExecuteNonQuery();
                lasterrorString = string.Empty;
                return true;
            }
            catch (Exception e)
            {
                lasterrorString = e.Message;
                return false;
            }
        }

        /// <summary>
        /// Обертка для выполнения команды с возвратом единственного значения
        /// </summary>
        /// <param name="SQL">оператор команды</param>
        /// <param name="columns">параметры</param>
        /// <returns></returns>
        public object? ExecScalarSQL(string SQL, Dictionary<string, object>? columns = null)
        {
            using MySqlCommand command = new MySqlCommand(SQL, myConnection);
            try
            {
                if (columns != null)
                {
                    foreach (var key in columns.Keys)
                        command.Parameters.AddWithValue($"@{key}", columns[key]);
                }
                var result = command.ExecuteScalar();
                lasterrorString = string.Empty;
                return result;
            }
            catch (Exception e)
            {
                lasterrorString = e.Message;
                return null;
            }
        }

        /// <summary>
        /// Запрос на вставку данных
        /// </summary>
        /// <param name="table"></param>
        /// <param name="columns"></param>
        public bool InsertInto(string table, Dictionary<string, object> columns)
        {
            // формирование запроса для изменения
            var props = new List<string>();
            var values = new List<string>();
            foreach (var key in columns.Keys)
            {
                props.Add($"`{key}`");
                var value = columns[key];
                values.Add($"@{key}");
            }
            var sql = $"INSERT INTO `{table}` ({string.Join(",", props)}) VALUES ({string.Join(",", values)})";
            return ExecSQL(sql, columns);
        }

        /// <summary>
        /// Запрос на изменение данных
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="columns">Набор данных для изменения</param>
        /// <returns></returns>
        public bool UpdateInto(string table, Dictionary<string, object> columns)
        {
            // формирование запроса для изменения
            var values = new List<string>();
            var indexName = columns.Keys.First();
            foreach (var key in columns.Keys.Skip(1)) values.Add($"`{key}`=@{key}");
            var sql = $"UPDATE `{table}` SET {string.Join(", ", values)} WHERE `{indexName}`=@{indexName}";
            return ExecSQL(sql, columns);
        }


        /// <summary>
        /// Запрос на удаление данных
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="columns">Набор данных для удаления</param>
        /// <returns></returns>
        public bool DeleteInto(string table, Dictionary<string, object> columns)
        {
            // формирование запроса для изменения
            var indexName = columns.Keys.First();
            var sql = $"DELETE FROM `{table}` WHERE `{indexName}`=@{indexName}";
            return ExecSQL(sql, columns);
        }

        /// <summary>
        /// Запрос на выборку данных
        /// </summary>
        /// <param name="sql">текст запроса</param>
        /// <param name="readed">функция обратного вызова</param>
        public void SqlFrom(string sql, GetReaded readed)
        {
            using MySqlCommand command = new MySqlCommand(sql, myConnection);
            using MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var values = new object[reader.FieldCount];
                    for (var i = 0; i < reader.FieldCount; i++)
                        values[i] = reader.GetValue(i);
                    readed(values);
                }
            }
        }

        /// <summary>
        /// Запрос на выборку данных из таблицы
        /// </summary>
        /// <param name="table">имя таблицы</param>
        /// <param name="readed">функция обратного вызова</param>
        /// <param name="where">предложение фильтра</param>
        /// <param name="orderby">предложение сортировки</param>
        public void SelectFrom(string table, GetReaded readed, string? where = null, string? orderby = null)
        {
            string SQL = $"SELECT * FROM `{table}` {where} {orderby}";
            using MySqlCommand command = new MySqlCommand(SQL, myConnection);
            using MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var values = new object[reader.FieldCount];
                    for (var i = 0; i < reader.FieldCount; i++)
                        values[i] = reader.GetValue(i);
                    readed(values);
                }
            }
        }

        /// <summary>
        /// Запрос на выборку данных
        /// </summary>
        /// <param name="sql">предложение запроса</param>
        /// <param name="readed">функция обратного вызова</param>
        public void SelectReader(string sql, GetReaded readed)
        {
            using MySqlCommand command = new MySqlCommand(sql, myConnection);
            using MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var values = new object[reader.FieldCount];
                    for (var i = 0; i < reader.FieldCount; i++)
                        values[i] = reader.GetValue(i);
                    readed(values);
                }
            }
        }

        //public static bool HostIsLocalhost()
        //{
        //    string host = Properties.Settings.Default.Host.ToLower();
        //    return host.Equals("localhost") || host.Equals("127.0.0.1");
        //}

    }
}
