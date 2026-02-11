using System.Windows;
using System.Windows.Controls;

namespace QuizViewer
{
    /// <summary>
    /// Логика взаимодействия для PageQuestion.xaml
    /// </summary>
    public partial class PageQuestion : Page
    {
        private readonly Frame mainFrame;
        private readonly PageQuestionModel model;

        public PageQuestion(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            model = (PageQuestionModel)DataContext;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            model.Assign(Root.Tournament.CurrentQuestion);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Tournament.GoPrevQuestion();
            mainFrame.Navigate(new PageQuestion(mainFrame));
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            Tournament.GoNextQuestion();
            mainFrame.Navigate(new PageQuestion(mainFrame));
        }
    }
}
