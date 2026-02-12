namespace ImportImageHelper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            pbImage = new PictureBox();
            toolStrip1 = new ToolStrip();
            tsbOpen = new ToolStripButton();
            tsbSaveAs = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbCopy = new ToolStripButton();
            tsbPaste = new ToolStripButton();
            tbString = new TextBox();
            menuStrip1 = new MenuStrip();
            tsmiFile = new ToolStripMenuItem();
            tsmiOpen = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            tsmiSaveAs = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiExit = new ToolStripMenuItem();
            tsmiClipboardCommands = new ToolStripMenuItem();
            tsmiCopy = new ToolStripMenuItem();
            tsmiPaste = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pbImage, 0, 2);
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 1);
            tableLayoutPanel1.Controls.Add(tbString, 0, 3);
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 567);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pbImage
            // 
            pbImage.BackColor = SystemColors.AppWorkspace;
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(3, 52);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(794, 389);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbOpen, tsbSaveAs, toolStripSeparator2, tsbCopy, tsbPaste });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            tsbOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbOpen.Image = (Image)resources.GetObject("tsbOpen.Image");
            tsbOpen.ImageTransparentColor = Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(23, 22);
            tsbOpen.Text = "&Открыть";
            tsbOpen.Click += tsmiOpen_Click;
            // 
            // tsbSaveAs
            // 
            tsbSaveAs.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSaveAs.Enabled = false;
            tsbSaveAs.Image = (Image)resources.GetObject("tsbSaveAs.Image");
            tsbSaveAs.ImageTransparentColor = Color.Magenta;
            tsbSaveAs.Name = "tsbSaveAs";
            tsbSaveAs.Size = new Size(23, 22);
            tsbSaveAs.Text = "Сохранить &как";
            tsbSaveAs.Click += tsmiSaveAs_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tsbCopy
            // 
            tsbCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCopy.Enabled = false;
            tsbCopy.Image = (Image)resources.GetObject("tsbCopy.Image");
            tsbCopy.ImageTransparentColor = Color.Magenta;
            tsbCopy.Name = "tsbCopy";
            tsbCopy.Size = new Size(23, 22);
            tsbCopy.Text = "&Копировать";
            tsbCopy.Click += tsmiCopy_Click;
            // 
            // tsbPaste
            // 
            tsbPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbPaste.Enabled = false;
            tsbPaste.Image = (Image)resources.GetObject("tsbPaste.Image");
            tsbPaste.ImageTransparentColor = Color.Magenta;
            tsbPaste.Name = "tsbPaste";
            tsbPaste.Size = new Size(23, 22);
            tsbPaste.Text = "&Вставить";
            tsbPaste.Click += tsmiPaste_Click;
            // 
            // tbString
            // 
            tbString.Dock = DockStyle.Fill;
            tbString.Location = new Point(3, 447);
            tbString.Multiline = true;
            tbString.Name = "tbString";
            tbString.ReadOnly = true;
            tbString.ScrollBars = ScrollBars.Both;
            tbString.Size = new Size(794, 117);
            tbString.TabIndex = 1;
            tbString.WordWrap = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiFile, tsmiClipboardCommands });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            tsmiFile.DropDownItems.AddRange(new ToolStripItem[] { tsmiOpen, toolStripSeparator, tsmiSaveAs, toolStripSeparator1, tsmiExit });
            tsmiFile.Name = "tsmiFile";
            tsmiFile.Size = new Size(48, 20);
            tsmiFile.Text = "&Файл";
            // 
            // tsmiOpen
            // 
            tsmiOpen.Image = (Image)resources.GetObject("tsmiOpen.Image");
            tsmiOpen.ImageTransparentColor = Color.Magenta;
            tsmiOpen.Name = "tsmiOpen";
            tsmiOpen.ShortcutKeys = Keys.Control | Keys.O;
            tsmiOpen.Size = new Size(194, 22);
            tsmiOpen.Text = "&Открыть";
            tsmiOpen.Click += tsmiOpen_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(191, 6);
            // 
            // tsmiSaveAs
            // 
            tsmiSaveAs.Enabled = false;
            tsmiSaveAs.Image = (Image)resources.GetObject("tsmiSaveAs.Image");
            tsmiSaveAs.ImageTransparentColor = Color.Magenta;
            tsmiSaveAs.Name = "tsmiSaveAs";
            tsmiSaveAs.ShortcutKeys = Keys.Control | Keys.S;
            tsmiSaveAs.Size = new Size(194, 22);
            tsmiSaveAs.Text = "Сохранить &как";
            tsmiSaveAs.Click += tsmiSaveAs_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(191, 6);
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(194, 22);
            tsmiExit.Text = "Вы&ход";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // tsmiClipboardCommands
            // 
            tsmiClipboardCommands.DropDownItems.AddRange(new ToolStripItem[] { tsmiCopy, tsmiPaste });
            tsmiClipboardCommands.Name = "tsmiClipboardCommands";
            tsmiClipboardCommands.Size = new Size(99, 20);
            tsmiClipboardCommands.Text = "&Буфер обмена";
            // 
            // tsmiCopy
            // 
            tsmiCopy.Enabled = false;
            tsmiCopy.Image = (Image)resources.GetObject("tsmiCopy.Image");
            tsmiCopy.ImageTransparentColor = Color.Magenta;
            tsmiCopy.Name = "tsmiCopy";
            tsmiCopy.ShortcutKeys = Keys.Control | Keys.C;
            tsmiCopy.Size = new Size(190, 22);
            tsmiCopy.Text = "&Копировать в";
            tsmiCopy.Click += tsmiCopy_Click;
            // 
            // tsmiPaste
            // 
            tsmiPaste.Enabled = false;
            tsmiPaste.Image = (Image)resources.GetObject("tsmiPaste.Image");
            tsmiPaste.ImageTransparentColor = Color.Magenta;
            tsmiPaste.Name = "tsmiPaste";
            tsmiPaste.ShortcutKeys = Keys.Control | Keys.V;
            tsmiPaste.Size = new Size(190, 22);
            tsmiPaste.Text = "&Вставить из";
            tsmiPaste.Click += tsmiPaste_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "png";
            openFileDialog1.Filter = "*.png|*.png|*.bmp|*.bmp|*.jpg|*.jpg";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(tableLayoutPanel1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Импорт картинки из буфера обмена в строку Base64";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbString;
        private PictureBox pbImage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem tsmiOpen;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem tsmiSaveAs;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem tsmiClipboardCommands;
        private ToolStripMenuItem tsmiPaste;
        private ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.Timer timer1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbOpen;
        private ToolStripButton tsbSaveAs;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbCopy;
        private ToolStripButton tsbPaste;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
