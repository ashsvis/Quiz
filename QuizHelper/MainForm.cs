namespace QuizHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var connectionPanel = new ConnectionUC() { Dock = DockStyle.Fill };
            connectionPanel.Close += (o, e) => 
            {
                Controls.Clear();
            };
            connectionPanel.ConnectedAndClose += (o, e) =>
            {
                Controls.Clear();
            };
            Controls.Add(connectionPanel);
        }
    }
}
