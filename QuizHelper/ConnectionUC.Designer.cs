namespace QuizHelper
{
    partial class ConnectionUC
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
            label1 = new Label();
            tbDatabase = new TextBox();
            label2 = new Label();
            tbServer = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbUser = new TextBox();
            label5 = new Label();
            tbPassword = new TextBox();
            nudPort = new NumericUpDown();
            btnOk = new Button();
            btnCancel = new Button();
            btnTest = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nudPort).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(73, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 33);
            label1.TabIndex = 0;
            label1.Text = "Имя базы данных:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbDatabase
            // 
            tbDatabase.BorderStyle = BorderStyle.FixedSingle;
            tbDatabase.Location = new Point(199, 51);
            tbDatabase.Margin = new Padding(4);
            tbDatabase.Name = "tbDatabase";
            tbDatabase.Size = new Size(148, 25);
            tbDatabase.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(73, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 33);
            label2.TabIndex = 0;
            label2.Text = "IP-адрес сервера:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbServer
            // 
            tbServer.BorderStyle = BorderStyle.FixedSingle;
            tbServer.Location = new Point(199, 84);
            tbServer.Margin = new Padding(4);
            tbServer.Name = "tbServer";
            tbServer.Size = new Size(148, 25);
            tbServer.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(73, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 33);
            label3.TabIndex = 0;
            label3.Text = "Номер порта:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(73, 146);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 33);
            label4.TabIndex = 0;
            label4.Text = "Пользователь:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbUser
            // 
            tbUser.BorderStyle = BorderStyle.FixedSingle;
            tbUser.Location = new Point(199, 150);
            tbUser.Margin = new Padding(4);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(148, 25);
            tbUser.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(73, 179);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 33);
            label5.TabIndex = 0;
            label5.Text = "Пароль:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Location = new Point(199, 183);
            tbPassword.Margin = new Padding(4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(148, 25);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // nudPort
            // 
            nudPort.BorderStyle = BorderStyle.FixedSingle;
            nudPort.Location = new Point(199, 117);
            nudPort.Margin = new Padding(4);
            nudPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudPort.Name = "nudPort";
            nudPort.Size = new Size(71, 25);
            nudPort.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Gainsboro;
            btnOk.DialogResult = DialogResult.OK;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point(100, 4);
            btnOk.Margin = new Padding(4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(76, 35);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ввод";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(184, 4);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(72, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.Gainsboro;
            btnTest.FlatAppearance.BorderSize = 0;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.Location = new Point(4, 4);
            btnTest.Margin = new Padding(4);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(88, 35);
            btnTest.TabIndex = 8;
            btnTest.TabStop = false;
            btnTest.Text = "Тест";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(tbDatabase, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(tbServer, 2, 2);
            tableLayoutPanel1.Controls.Add(tbPassword, 2, 5);
            tableLayoutPanel1.Controls.Add(nudPort, 2, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 5);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(tbUser, 2, 4);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(420, 310);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 3);
            flowLayoutPanel1.Controls.Add(btnTest);
            flowLayoutPanel1.Controls.Add(btnOk);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Location = new Point(87, 216);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(260, 43);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // ConnectionUC
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "ConnectionUC";
            Size = new Size(420, 310);
            Load += ConnectionUC_Load;
            ((System.ComponentModel.ISupportInitialize)nudPort).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
