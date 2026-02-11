using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace QuizViewer
{
    /// <summary>
    /// Логика взаимодействия для PagePagePlayVideo.xaml
    /// </summary>
    public partial class PagePlayVideo : Page
    {
        private readonly Frame mainFrame;
        private readonly bool? sound;
        private readonly string? soundpath;
        private readonly Page? page;
        private readonly float duration;

        public PagePlayVideo(Page? page, float duration, string videopath, Frame mainFrame, bool? sound = true, string? soundpath = null)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            this.sound = sound;
            this.soundpath = soundpath;
            this.page = page;
            this.duration = duration;
            this.Title = "Демонстрация клипа: " + System.IO.Path.GetFileNameWithoutExtension(videopath);
            this.Loaded += Page_Loaded;
            videoPlayer.Source = new Uri(videopath);
            videoPlayer.MediaEnded += MePlayer_MediaEnded;
            videoPlayer.MouseDown += MePlayer_MouseDown;
            if (sound != true)
            {
                videoPlayer.Volume = 0;
                if (soundpath != null)
                    soundPlayer.Source = new Uri(soundpath);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (sound != true && !string.IsNullOrEmpty(soundpath))
                soundPlayer.Play();
            videoPlayer.Position = TimeSpan.FromSeconds(duration);
            videoPlayer.Play();
        }

        private void MePlayer_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            mainFrame.Navigate(page ?? new PageTitle(mainFrame));
        }

        private void MePlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(page ?? new PageTitle(mainFrame));
        }
    }
}
