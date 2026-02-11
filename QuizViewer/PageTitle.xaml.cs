using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace QuizViewer
{
    /// <summary>
    /// Логика взаимодействия для PageTitle.xaml
    /// </summary>
    public partial class PageTitle : Page
    {
        private readonly Frame mainFrame;
        private readonly PageTurnamentModel model;

        public PageTitle(Frame mainFrame, string soundfile = "")
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            model = (PageTurnamentModel)DataContext;
            if (PageTurnamentModel.CurrentQuestion != null && PageTurnamentModel.CurrentQuestion.PrevQuestion == null)
                SoundFile("meeting.mp3");
            else if (!string.IsNullOrEmpty(soundfile)) 
                SoundFile(soundfile);
        }

        private void Label_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (Root.Tournament.CurrentQuestion != null)
            {
                var videofile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Media\Запуск волчка.mp4");
                var soundfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Media\volchok.mp3");
                if (File.Exists(videofile) && File.Exists(soundfile))
                    mainFrame.Navigate(new PagePlayVideo(new PageQuestion(mainFrame), 7f, videofile, mainFrame, false, soundfile));
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
    }
}
