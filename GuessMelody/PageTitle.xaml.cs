using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace GuessMelody
{
    /// <summary>
    /// Логика взаимодействия для PageTitle.xaml
    /// </summary>
    public partial class PageTitle : Page
    {
        private readonly Frame mainFrame;
        private readonly PageTitleModel model;

        private readonly Queue<Action> actions = [];

        public PageTitle(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            model = (PageTitleModel)DataContext;
            videoPlayer.MediaEnded += MePlayer_MediaEnded;
            videoPlayer.MouseDown += MePlayer_MouseDown;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            model.Assign(Root.Presentation.Slide);
            SoundFile("opening2013.mp3");
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

        private void buttonPlayFragment_Click(object sender, RoutedEventArgs e)
        {
            SoundFile(model.SoundMinus);
        }

        private void buttonPlaySound_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (Root.Presentation.Slide is Slide slide)
            {
                model.Title = slide.Title;
                model.Image = slide.Image;
                SoundFile(model.Sound);
            }
        }

        private void buttonPlayVideo_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (Root.Presentation.Slide is Slide slide)
            {
                model.Title = slide.Title;
                model.Image = null;
                SoundFile(model.Video);
            }
        }

        private void MePlayer_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            GoToNextSlide();
        }

        private void MePlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            GoToNextSlide();
        }

        private void GoToNextSlide()
        {
            videoPlayer.Stop();
            model.Title = "";
            model.SoundMinus = "";
            model.Sound = "";
            model.Video = "";
            videoPlayer.Visibility = Visibility.Hidden;
            model.Image = null;
            soundImage.Source = null;
            soundImage.Visibility = Visibility.Visible;
        }
    }
}
