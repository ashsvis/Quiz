using QuizModel;

namespace QuizHelper
{
    public partial class ConnectionUC : UserControl
    {
        public event EventHandler? Close;
        public event EventHandler? ConnectedAndClose;

        private bool isConnected;

        public ConnectionUC()
        {
            InitializeComponent();
            CheckConnection();
        }

        private void ConnectionUC_Load(object sender, EventArgs e)
        {
            tbDatabase.Text = Properties.Settings.Default.Database;
            tbServer.Text = Properties.Settings.Default.Host;
            nudPort.Value = Properties.Settings.Default.Port;
            tbUser.Text = Properties.Settings.Default.User;
            tbPassword.Text = Properties.Settings.Default.Password;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Database = tbDatabase.Text;
            Properties.Settings.Default.Host = tbServer.Text;
            Properties.Settings.Default.Port = nudPort.Value;
            Properties.Settings.Default.User = tbUser.Text;
            Properties.Settings.Default.Password = tbPassword.Text;
            Properties.Settings.Default.Save();
            if (isConnected)
                ConnectedAndClose?.Invoke(this, EventArgs.Empty);
            else
                Close?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Тестирование настроек соединения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Database = tbDatabase.Text;
            Properties.Settings.Default.Host = tbServer.Text;
            Properties.Settings.Default.Port = nudPort.Value;
            Properties.Settings.Default.User = tbUser.Text;
            Properties.Settings.Default.Password = tbPassword.Text;

            CheckConnection();
            if (isConnected)
                MessageBox.Show(this, "Успешное подключение", "Проверка подключения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, ServerSQL.LastError, "Проверка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void CheckConnection()
        {
            if (isConnected) return;
            var connectionString =
                "server=" + Properties.Settings.Default.Host +
                ";user=" + Properties.Settings.Default.User +
                ";port=" + Properties.Settings.Default.Port +
                ";password=" + Properties.Settings.Default.Password + ";";
            var database = Properties.Settings.Default.Database;
            using ServerSQL server = new(connectionString, database);
            isConnected = server.Connected;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close?.Invoke(this, EventArgs.Empty);
        }
    }
}
