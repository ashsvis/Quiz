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
        private readonly float duration;

        public PagePlayVideo(Page? page, float duration, string path, Frame mainFrame, bool? sound = true)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            this.page = page;
            this.duration = duration;
            this.Title = "Демонстрация клипа: " + System.IO.Path.GetFileNameWithoutExtension(path);
            this.Loaded += Page_Loaded;
            mePlayer.Source = new Uri(path);
            mePlayer.MediaEnded += MePlayer_MediaEnded;
            mePlayer.MouseDown += MePlayer_MouseDown;
            if (sound != true)
                mePlayer.Volume = 0;
        }

        private void MePlayer_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            mainFrame.Navigate(page ?? new PageTitle(mainFrame));
        }

        private void MePlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(page ?? new PageTitle(mainFrame));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            mePlayer.Position = TimeSpan.FromSeconds(duration);
            mePlayer.Play();
        }
    }
}
