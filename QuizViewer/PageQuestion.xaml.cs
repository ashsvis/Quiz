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
        private readonly Question? question;
        private readonly PageQuestionModel model;

        public PageQuestion(Frame mainFrame, Question? question)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            this.question = question;
            model = (PageQuestionModel)DataContext;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //mePlayer.Play();
            model.Assign(question);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (question == null || question.PrevQuestion == null) return;
            mainFrame.Navigate(new PageQuestion(mainFrame, question.PrevQuestion));
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if (question == null || question.NextQuestion == null) return;
            mainFrame.Navigate(new PageQuestion(mainFrame, question.NextQuestion));
        }
    }
}
