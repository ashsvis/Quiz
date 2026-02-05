namespace QuizHelper
{
    partial class QuizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOk = new Button();
            btnCancel = new Button();
            tbName = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label3 = new Label();
            tbContacts = new TextBox();
            label4 = new Label();
            tbOfficeAddress = new TextBox();
            tbDescriptor = new TextBox();
            btnPasteFromClipboard = new Button();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.BackColor = Color.Gainsboro;
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Enabled = false;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point(298, 250);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 27);
            btnOk.TabIndex = 30;
            btnOk.Text = "Ввод";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(379, 250);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 27);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.BorderStyle = BorderStyle.FixedSingle;
            tbName.Location = new Point(134, 15);
            tbName.MaxLength = 250;
            tbName.Name = "tbName";
            tbName.Size = new Size(320, 23);
            tbName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 18);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 42;
            label1.Text = "Наименование:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 106);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 42;
            label8.Text = "Описание:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 47);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 42;
            label3.Text = "Контакты:";
            // 
            // tbContacts
            // 
            tbContacts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbContacts.BorderStyle = BorderStyle.FixedSingle;
            tbContacts.Location = new Point(134, 44);
            tbContacts.MaxLength = 250;
            tbContacts.Name = "tbContacts";
            tbContacts.Size = new Size(320, 23);
            tbContacts.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 76);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 42;
            label4.Text = "Адрес офиса:";
            // 
            // tbOfficeAddress
            // 
            tbOfficeAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbOfficeAddress.BorderStyle = BorderStyle.FixedSingle;
            tbOfficeAddress.Location = new Point(134, 73);
            tbOfficeAddress.MaxLength = 250;
            tbOfficeAddress.Name = "tbOfficeAddress";
            tbOfficeAddress.Size = new Size(320, 23);
            tbOfficeAddress.TabIndex = 2;
            // 
            // tbDescriptor
            // 
            tbDescriptor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDescriptor.BorderStyle = BorderStyle.FixedSingle;
            tbDescriptor.Location = new Point(15, 129);
            tbDescriptor.MaxLength = 250;
            tbDescriptor.Multiline = true;
            tbDescriptor.Name = "tbDescriptor";
            tbDescriptor.Size = new Size(439, 117);
            tbDescriptor.TabIndex = 3;
            // 
            // btnPasteFromClipboard
            // 
            btnPasteFromClipboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPasteFromClipboard.BackColor = Color.Gainsboro;
            btnPasteFromClipboard.FlatAppearance.BorderSize = 0;
            btnPasteFromClipboard.FlatStyle = FlatStyle.Flat;
            btnPasteFromClipboard.Location = new Point(15, 250);
            btnPasteFromClipboard.Name = "btnPasteFromClipboard";
            btnPasteFromClipboard.Size = new Size(175, 27);
            btnPasteFromClipboard.TabIndex = 31;
            btnPasteFromClipboard.Text = "Вставка из буфера обмена";
            btnPasteFromClipboard.UseVisualStyleBackColor = false;
            btnPasteFromClipboard.Visible = false;
            // 
            // QuizeForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = btnCancel;
            ClientSize = new Size(466, 282);
            Controls.Add(label8);
            Controls.Add(tbDescriptor);
            Controls.Add(tbOfficeAddress);
            Controls.Add(label4);
            Controls.Add(tbContacts);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(btnPasteFromClipboard);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QuizeForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Вопрос";
            Load += QuizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbContacts;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbOfficeAddress;
        public System.Windows.Forms.TextBox tbDescriptor;
        private Button btnPasteFromClipboard;
    }
}