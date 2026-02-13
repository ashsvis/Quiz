using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Controls;

namespace GuessMelody
{
    /// <summary>
    /// Логика взаимодействия для PageEnding.xaml
    /// </summary>
    public partial class PageEnding : Page
    {
        private readonly Frame mainFrame;

        public PageEnding(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SoundFile("Полина Гагарина - Спектакль окончен.mp4");
        }

        private void SoundFile(string? filename)
        {
            var soundfile = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Media\" + filename);
            if (File.Exists(soundfile))
            {
                videoPlayer.Stop();
                videoPlayer.Source = new Uri(soundfile);
                videoPlayer.Play();
            }
        }
    }
}
