namespace QuizHelper
{
    partial class QuestionsUC
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lvTable = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // lvTable
            // 
            lvTable.BackColor = Color.Gainsboro;
            lvTable.BorderStyle = BorderStyle.FixedSingle;
            lvTable.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3 });
            lvTable.Dock = DockStyle.Fill;
            lvTable.FullRowSelect = true;
            lvTable.Location = new Point(0, 0);
            lvTable.MultiSelect = false;
            lvTable.Name = "lvTable";
            lvTable.ShowItemToolTips = true;
            lvTable.Size = new Size(863, 434);
            lvTable.TabIndex = 1;
            lvTable.UseCompatibleStateImageBehavior = false;
            lvTable.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 40;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Вопрос";
            columnHeader3.Width = 800;
            // 
            // QuestionsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lvTable);
            Name = "QuestionsUC";
            Size = new Size(863, 434);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
    }
}
