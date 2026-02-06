namespace QuizHelper
{
    partial class AnswerUC
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
            tplGrid = new TableLayoutPanel();
            tbComments = new TextBox();
            tbSources = new TextBox();
            tbAuthors = new TextBox();
            tbAnswer = new TextBox();
            tbQuestion = new TextBox();
            tbEditors = new TextBox();
            tbTournament = new TextBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tbTour = new TextBox();
            lbQuestionsCount = new Label();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lbQuestionNumber = new Label();
            tbQuestionNumber = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tplGrid.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tplGrid
            // 
            tplGrid.ColumnCount = 1;
            tplGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tplGrid.Controls.Add(tbComments, 0, 13);
            tplGrid.Controls.Add(tbSources, 0, 11);
            tplGrid.Controls.Add(tbAuthors, 0, 9);
            tplGrid.Controls.Add(tbAnswer, 0, 7);
            tplGrid.Controls.Add(tbQuestion, 0, 5);
            tplGrid.Controls.Add(tbEditors, 0, 3);
            tplGrid.Controls.Add(tbTournament, 0, 0);
            tplGrid.Controls.Add(label1, 0, 2);
            tplGrid.Controls.Add(flowLayoutPanel1, 0, 1);
            tplGrid.Controls.Add(label3, 0, 6);
            tplGrid.Controls.Add(flowLayoutPanel2, 0, 4);
            tplGrid.Controls.Add(label4, 0, 8);
            tplGrid.Controls.Add(label5, 0, 10);
            tplGrid.Controls.Add(label6, 0, 12);
            tplGrid.Dock = DockStyle.Fill;
            tplGrid.Location = new Point(0, 0);
            tplGrid.Margin = new Padding(4);
            tplGrid.Name = "tplGrid";
            tplGrid.Padding = new Padding(5);
            tplGrid.RowCount = 14;
            tplGrid.RowStyles.Add(new RowStyle());
            tplGrid.RowStyles.Add(new RowStyle());
            tplGrid.RowStyles.Add(new RowStyle());
            tplGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tplGrid.RowStyles.Add(new RowStyle());
            tplGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 41.6666679F));
            tplGrid.RowStyles.Add(new RowStyle());
            tplGrid.RowStyles.Add(new RowStyle());
            tplGrid.RowStyles.Add(new RowStyle());
            tplGrid.RowStyles.Add(new RowStyle());
            tplGrid.RowStyles.Add(new RowStyle());
            tplGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tplGrid.RowStyles.Add(new RowStyle());
            tplGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tplGrid.Size = new Size(1017, 680);
            tplGrid.TabIndex = 0;
            // 
            // tbComments
            // 
            tbComments.AcceptsReturn = true;
            tbComments.AcceptsTab = true;
            tbComments.BackColor = Color.WhiteSmoke;
            tbComments.BorderStyle = BorderStyle.None;
            tbComments.Dock = DockStyle.Fill;
            tbComments.Location = new Point(5, 569);
            tbComments.Margin = new Padding(0);
            tbComments.Multiline = true;
            tbComments.Name = "tbComments";
            tbComments.ScrollBars = ScrollBars.Both;
            tbComments.Size = new Size(1007, 106);
            tbComments.TabIndex = 6;
            tbComments.WordWrap = false;
            // 
            // tbSources
            // 
            tbSources.AcceptsReturn = true;
            tbSources.AcceptsTab = true;
            tbSources.BackColor = Color.WhiteSmoke;
            tbSources.BorderStyle = BorderStyle.None;
            tbSources.Dock = DockStyle.Fill;
            tbSources.Location = new Point(5, 483);
            tbSources.Margin = new Padding(0);
            tbSources.Multiline = true;
            tbSources.Name = "tbSources";
            tbSources.ScrollBars = ScrollBars.Both;
            tbSources.Size = new Size(1007, 70);
            tbSources.TabIndex = 5;
            tbSources.WordWrap = false;
            // 
            // tbAuthors
            // 
            tbAuthors.BackColor = Color.WhiteSmoke;
            tbAuthors.BorderStyle = BorderStyle.None;
            tbAuthors.Dock = DockStyle.Fill;
            tbAuthors.Location = new Point(5, 428);
            tbAuthors.Margin = new Padding(0);
            tbAuthors.Name = "tbAuthors";
            tbAuthors.Size = new Size(1007, 19);
            tbAuthors.TabIndex = 4;
            // 
            // tbAnswer
            // 
            tbAnswer.BackColor = Color.WhiteSmoke;
            tbAnswer.BorderStyle = BorderStyle.None;
            tbAnswer.Dock = DockStyle.Fill;
            tbAnswer.Location = new Point(5, 373);
            tbAnswer.Margin = new Padding(0);
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Size = new Size(1007, 19);
            tbAnswer.TabIndex = 3;
            // 
            // tbQuestion
            // 
            tbQuestion.AcceptsReturn = true;
            tbQuestion.AcceptsTab = true;
            tbQuestion.BackColor = Color.WhiteSmoke;
            tbQuestion.BorderStyle = BorderStyle.None;
            tbQuestion.Dock = DockStyle.Fill;
            tbQuestion.Location = new Point(5, 182);
            tbQuestion.Margin = new Padding(0);
            tbQuestion.Multiline = true;
            tbQuestion.Name = "tbQuestion";
            tbQuestion.ScrollBars = ScrollBars.Both;
            tbQuestion.Size = new Size(1007, 175);
            tbQuestion.TabIndex = 2;
            tbQuestion.WordWrap = false;
            // 
            // tbEditors
            // 
            tbEditors.AcceptsReturn = true;
            tbEditors.AcceptsTab = true;
            tbEditors.BackColor = Color.WhiteSmoke;
            tbEditors.BorderStyle = BorderStyle.None;
            tbEditors.Dock = DockStyle.Fill;
            tbEditors.Location = new Point(5, 76);
            tbEditors.Margin = new Padding(0);
            tbEditors.Multiline = true;
            tbEditors.Name = "tbEditors";
            tbEditors.ScrollBars = ScrollBars.Both;
            tbEditors.Size = new Size(1007, 70);
            tbEditors.TabIndex = 0;
            tbEditors.WordWrap = false;
            // 
            // tbTournament
            // 
            tbTournament.BackColor = Color.WhiteSmoke;
            tbTournament.BorderStyle = BorderStyle.None;
            tbTournament.Dock = DockStyle.Fill;
            tbTournament.Location = new Point(9, 9);
            tbTournament.Margin = new Padding(4);
            tbTournament.Name = "tbTournament";
            tbTournament.Size = new Size(999, 19);
            tbTournament.TabIndex = 0;
            tbTournament.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 9.75F);
            label1.Location = new Point(9, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 16);
            label1.TabIndex = 1;
            label1.Text = "Редакторы:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(tbTour);
            flowLayoutPanel1.Controls.Add(lbQuestionsCount);
            flowLayoutPanel1.Location = new Point(373, 32);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(271, 28);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // tbTour
            // 
            tbTour.Anchor = AnchorStyles.Left;
            tbTour.BackColor = Color.WhiteSmoke;
            tbTour.BorderStyle = BorderStyle.None;
            tbTour.Location = new Point(0, 4);
            tbTour.Margin = new Padding(0);
            tbTour.Name = "tbTour";
            tbTour.Size = new Size(142, 19);
            tbTour.TabIndex = 0;
            tbTour.TextAlign = HorizontalAlignment.Center;
            // 
            // lbQuestionsCount
            // 
            lbQuestionsCount.Anchor = AnchorStyles.Left;
            lbQuestionsCount.Location = new Point(142, 0);
            lbQuestionsCount.Margin = new Padding(0);
            lbQuestionsCount.Name = "lbQuestionsCount";
            lbQuestionsCount.Size = new Size(129, 28);
            lbQuestionsCount.TabIndex = 1;
            lbQuestionsCount.Text = "(? вопросов)";
            lbQuestionsCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9.75F);
            label3.Location = new Point(9, 357);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 16);
            label3.TabIndex = 1;
            label3.Text = "Ответ:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(lbQuestionNumber);
            flowLayoutPanel2.Controls.Add(tbQuestionNumber);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(9, 150);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(103, 28);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.WrapContents = false;
            // 
            // lbQuestionNumber
            // 
            lbQuestionNumber.Anchor = AnchorStyles.Left;
            lbQuestionNumber.AutoSize = true;
            lbQuestionNumber.Font = new Font("Georgia", 9.75F);
            lbQuestionNumber.Location = new Point(4, 6);
            lbQuestionNumber.Margin = new Padding(4, 0, 4, 0);
            lbQuestionNumber.Name = "lbQuestionNumber";
            lbQuestionNumber.Size = new Size(54, 16);
            lbQuestionNumber.TabIndex = 1;
            lbQuestionNumber.Text = "Вопрос";
            // 
            // tbQuestionNumber
            // 
            tbQuestionNumber.Anchor = AnchorStyles.Left;
            tbQuestionNumber.BackColor = Color.WhiteSmoke;
            tbQuestionNumber.BorderStyle = BorderStyle.None;
            tbQuestionNumber.Location = new Point(62, 4);
            tbQuestionNumber.Margin = new Padding(0);
            tbQuestionNumber.Name = "tbQuestionNumber";
            tbQuestionNumber.Size = new Size(27, 19);
            tbQuestionNumber.TabIndex = 0;
            tbQuestionNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Georgia", 9.75F);
            label2.Location = new Point(89, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(14, 28);
            label2.TabIndex = 1;
            label2.Text = ":";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9.75F);
            label4.Location = new Point(9, 412);
            label4.Margin = new Padding(4, 20, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 16);
            label4.TabIndex = 1;
            label4.Text = "Автор(ы):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9.75F);
            label5.Location = new Point(9, 467);
            label5.Margin = new Padding(4, 20, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 16);
            label5.TabIndex = 1;
            label5.Text = "Источник(и):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 9.75F);
            label6.Location = new Point(9, 553);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 16);
            label6.TabIndex = 1;
            label6.Text = "Комментарии:";
            // 
            // AnswerUC
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tplGrid);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "AnswerUC";
            Size = new Size(1017, 680);
            tplGrid.ResumeLayout(false);
            tplGrid.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tplGrid;
        private TextBox tbTournament;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox tbTour;
        private Label lbQuestionsCount;
        private Label label1;
        private Label lbQuestionNumber;
        private Label label3;
        private TextBox tbEditors;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox tbQuestionNumber;
        private Label label2;
        private TextBox tbAnswer;
        private TextBox tbQuestion;
        private TextBox tbSources;
        private TextBox tbAuthors;
        private Label label4;
        private Label label5;
        private TextBox tbComments;
        private Label label6;
    }
}
