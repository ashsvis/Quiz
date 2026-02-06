namespace QuizHelper
{
    partial class QuizesUC
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCreateNew = new Button();
            btnEditCurrent = new Button();
            btnDeleteCurrent = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAppendFromClipboard = new Button();
            tvTurnaments = new TreeView();
            panChildView = new Panel();
            timerDataChecker = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 296F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 2, 0);
            tableLayoutPanel1.Controls.Add(tvTurnaments, 0, 1);
            tableLayoutPanel1.Controls.Add(panChildView, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(977, 495);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(btnCreateNew);
            flowLayoutPanel1.Controls.Add(btnEditCurrent);
            flowLayoutPanel1.Controls.Add(btnDeleteCurrent);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(461, 33);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCreateNew
            // 
            btnCreateNew.BackColor = Color.Gainsboro;
            btnCreateNew.FlatAppearance.BorderSize = 0;
            btnCreateNew.FlatStyle = FlatStyle.Flat;
            btnCreateNew.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCreateNew.Location = new Point(3, 3);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(102, 27);
            btnCreateNew.TabIndex = 1;
            btnCreateNew.Text = "Новая запись";
            btnCreateNew.UseVisualStyleBackColor = false;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // btnEditCurrent
            // 
            btnEditCurrent.BackColor = Color.Gainsboro;
            btnEditCurrent.Enabled = false;
            btnEditCurrent.FlatAppearance.BorderSize = 0;
            btnEditCurrent.FlatStyle = FlatStyle.Flat;
            btnEditCurrent.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEditCurrent.Location = new Point(111, 3);
            btnEditCurrent.Name = "btnEditCurrent";
            btnEditCurrent.Size = new Size(172, 27);
            btnEditCurrent.TabIndex = 2;
            btnEditCurrent.Text = "Изменить текущую запись";
            btnEditCurrent.UseVisualStyleBackColor = false;
            btnEditCurrent.Click += btnEditCurrent_Click;
            // 
            // btnDeleteCurrent
            // 
            btnDeleteCurrent.BackColor = Color.Gainsboro;
            btnDeleteCurrent.Enabled = false;
            btnDeleteCurrent.FlatAppearance.BorderSize = 0;
            btnDeleteCurrent.FlatStyle = FlatStyle.Flat;
            btnDeleteCurrent.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteCurrent.Location = new Point(289, 3);
            btnDeleteCurrent.Name = "btnDeleteCurrent";
            btnDeleteCurrent.Size = new Size(169, 27);
            btnDeleteCurrent.TabIndex = 3;
            btnDeleteCurrent.Text = "Удалить текущую запись";
            btnDeleteCurrent.UseVisualStyleBackColor = false;
            btnDeleteCurrent.Click += btnDeleteCurrent_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(btnAppendFromClipboard);
            flowLayoutPanel2.Location = new Point(711, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(263, 33);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // btnAppendFromClipboard
            // 
            btnAppendFromClipboard.BackColor = Color.Gainsboro;
            btnAppendFromClipboard.FlatAppearance.BorderSize = 0;
            btnAppendFromClipboard.FlatStyle = FlatStyle.Flat;
            btnAppendFromClipboard.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAppendFromClipboard.Location = new Point(3, 3);
            btnAppendFromClipboard.Name = "btnAppendFromClipboard";
            btnAppendFromClipboard.Size = new Size(257, 27);
            btnAppendFromClipboard.TabIndex = 2;
            btnAppendFromClipboard.Text = "Добавить новые записи из буфера обмена";
            btnAppendFromClipboard.UseVisualStyleBackColor = false;
            btnAppendFromClipboard.Visible = false;
            btnAppendFromClipboard.Click += btnAppendFromClipboard_Click;
            // 
            // tvTurnaments
            // 
            tvTurnaments.BackColor = Color.Gainsboro;
            tvTurnaments.BorderStyle = BorderStyle.FixedSingle;
            tvTurnaments.Dock = DockStyle.Fill;
            tvTurnaments.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tvTurnaments.FullRowSelect = true;
            tvTurnaments.HideSelection = false;
            tvTurnaments.Location = new Point(0, 39);
            tvTurnaments.Margin = new Padding(0);
            tvTurnaments.Name = "tvTurnaments";
            tvTurnaments.Size = new Size(296, 456);
            tvTurnaments.TabIndex = 2;
            tvTurnaments.AfterSelect += tvTurnaments_AfterSelect;
            // 
            // panChildView
            // 
            tableLayoutPanel1.SetColumnSpan(panChildView, 2);
            panChildView.Dock = DockStyle.Fill;
            panChildView.Location = new Point(296, 39);
            panChildView.Margin = new Padding(0);
            panChildView.Name = "panChildView";
            panChildView.Size = new Size(681, 456);
            panChildView.TabIndex = 3;
            // 
            // timerDataChecker
            // 
            timerDataChecker.Tick += timerDataChecker_Tick;
            // 
            // QuizesUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "QuizesUC";
            Size = new Size(1001, 519);
            Load += QuizesUC_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnEditCurrent;
        private System.Windows.Forms.Button btnDeleteCurrent;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAppendFromClipboard;
        private System.Windows.Forms.Timer timerDataChecker;
        private TreeView tvTurnaments;
        private Panel panChildView;
    }
}
