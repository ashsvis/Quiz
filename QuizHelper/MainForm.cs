namespace QuizHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var connectionPanel = new ConnectionUC() { Dock = DockStyle.Fill };
            var isConnected = connectionPanel.EnshureConnection();
            if (isConnected)
            {
                ShowQuizesPanel();
            }
            else
            {
                connectionPanel.Close += (o, e) =>
                {
                    Controls.Clear();
                };
                connectionPanel.ConnectedAndClose += (o, e) =>
                {
                    ShowQuizesPanel();
                };
                Controls.Add(connectionPanel);
            }

        }

        private void ShowQuizesPanel()
        {
            Controls.Clear();
            var quizesPanel = new QuizesUC() { Dock = DockStyle.Fill };
            Controls.Add(quizesPanel);
        }
    }
}
