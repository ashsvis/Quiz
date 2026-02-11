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
            mainFrame.Navigate(new PageTitle(mainFrame));
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            Tournament.GoNextQuestion();
            mainFrame.Navigate(new PageTitle(mainFrame));
        }

        private void btnAnswerA_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Tournament.CheckAnswer("A");
            Tournament.GoNextQuestion();
            mainFrame.Navigate(new PageTitle(mainFrame));
        }

        private void btnAnswerB_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Tournament.CheckAnswer("B");
            Tournament.GoNextQuestion();
            mainFrame.Navigate(new PageTitle(mainFrame));
        }

        private void btnAnswerC_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Tournament.CheckAnswer("C");
            Tournament.GoNextQuestion();
            mainFrame.Navigate(new PageTitle(mainFrame));
        }

        private void btnAnswerD_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Tournament.CheckAnswer("D");
            Tournament.GoNextQuestion();
            mainFrame.Navigate(new PageTitle(mainFrame));
        }
    }
}
