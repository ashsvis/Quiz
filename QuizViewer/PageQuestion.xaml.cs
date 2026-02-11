using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace QuizViewer
{
    /// <summary>
    /// Логика взаимодействия для PageQuestion.xaml
    /// </summary>
    public partial class PageQuestion : Page
    {
        private readonly Frame mainFrame;
        private readonly PageQuestionModel model;
        private readonly Queue<Action> actions = [];
        private readonly DispatcherTimer timer;

        public PageQuestion(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            model = (PageQuestionModel)DataContext;
            soundPlayer.MediaOpened += SoundPlayer_MediaOpened;
            soundPlayer.MediaEnded += SoundPlayer_MediaEnded;
            timer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 4)
            };
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();
            if (Tournament.GoNextQuestion())
                mainFrame.Navigate(new PageTitle(mainFrame, Root.Tournament.IsWinQuestion ? "chgk2_yes1.mp3" : "chgk2_no1.mp3"));
        }

        private void SoundPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            model.Enabled = false;
        }

        private void SoundPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            model.Enabled = true;
            if (actions.Count > 0)
            {
                var action = actions.Dequeue();
                action.Invoke();
            }
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

        private void CheckAnswer(string choose, Border btnAnswer)
        {
            btnAnswer.Background = Brushes.Silver;
            SoundFile("chgk2_otvet.mp3");
            actions.Enqueue(new Action(() =>
            {
                btnAnswer.Background = Tournament.CheckAnswer(choose) ? Brushes.Lime : Brushes.Red;
                timer.Start();
            }));
        }

        private void btnAnswerA_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CheckAnswer("A", btnAnswerA);
        }

        private void btnAnswerB_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CheckAnswer("B", btnAnswerB);
        }

        private void btnAnswerC_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CheckAnswer("C", btnAnswerC);
        }

        private void btnAnswerD_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CheckAnswer("D", btnAnswerD);
        }
    }
}
