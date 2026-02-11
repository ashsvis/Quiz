using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace QuizViewer
{
    /// <summary>
    /// Логика взаимодействия для PageQuestion.xaml
    /// </summary>
    public partial class PageQuestion : Page
    {
        private readonly Frame mainFrame;
        private readonly PageQuestionModel model;
        private Action? chooseAnswer;

        public PageQuestion(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            model = (PageQuestionModel)DataContext;
            soundPlayer.MediaOpened += SoundPlayer_MediaOpened;
            soundPlayer.MediaEnded += SoundPlayer_MediaEnded;
        }

        private void SoundPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            model.Enabled = false;
        }

        private void SoundPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            model.Enabled = true;
            chooseAnswer?.Invoke();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            model.Assign(Root.Tournament.CurrentQuestion);
            if (Tournament.IsNextQuestion)
            {
                SoundFile("nextquestion.mp3");
            }
        }

        private void SoundFile(string filename)
        {
            var soundfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Media\" + filename);
            if (File.Exists(soundfile))
            {
                soundPlayer.Stop();
                soundPlayer.Source = new Uri(soundfile);
                soundPlayer.Play();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (Tournament.GoPrevQuestion())
                mainFrame.Navigate(new PageTitle(mainFrame));
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if (Tournament.GoNextQuestion())
                mainFrame.Navigate(new PageTitle(mainFrame));
        }

        private void CheckAnswer(string choose)
        {
            SoundFile("chgk2_otvet.mp3");
            chooseAnswer = new Action(() =>
            {
                Tournament.CheckAnswer(choose);
                if (Tournament.GoNextQuestion())
                    mainFrame.Navigate(new PageTitle(mainFrame));
            });
        }

        private void btnAnswerA_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CheckAnswer("A");
        }

        private void btnAnswerB_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CheckAnswer("B");
        }

        private void btnAnswerC_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CheckAnswer("C");
        }

        private void btnAnswerD_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CheckAnswer("D");
        }
    }
}
