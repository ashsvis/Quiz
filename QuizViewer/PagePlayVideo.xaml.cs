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
        private readonly Page? page;

        public PagePlayVideo(Page? page, float duration, string videopath, Frame mainFrame, bool? sound = true, string? soundpath = null)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            this.page = page;
            videoPlayer.Source = new Uri(videopath);
            videoPlayer.MediaEnded += MePlayer_MediaEnded;
            videoPlayer.MouseDown += MePlayer_MouseDown;
            videoPlayer.Position = TimeSpan.FromSeconds(duration);
            videoPlayer.Play();
            if (sound != true)
            {
                videoPlayer.Volume = 0;
                if (soundpath != null)
                {
                    soundPlayer.Source = new Uri(soundpath);
                    soundPlayer.Play();
                }
            }
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
