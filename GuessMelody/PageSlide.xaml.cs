using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace GuessMelody
{
    /// <summary>
    /// Логика взаимодействия для PageSlide.xaml
    /// </summary>
    public partial class PageSlide : Page
    {
        private readonly Frame mainFrame;
        private readonly PageSlideModel model;

        private readonly System.Media.SoundPlayer soundPlayer;
        private readonly Queue<Action> actions = [];
        private bool fragmentPlayed;

        public PageSlide(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            model = (PageSlideModel)DataContext;
            soundPlayer = new System.Media.SoundPlayer();
            videoPlayer.MediaOpened += VideoPlayer_MediaOpened;
            videoPlayer.MediaEnded += VideoPlayer_MediaEnded;
        }

        private void VideoPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            soundPlayer.Stop();
            if (videoPlayer.HasAudio && model.Image == null)
                soundImageFragment.Visibility = Visibility.Visible;
        }

        private void VideoPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            soundImageFragment.Visibility = Visibility.Collapsed;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            model.Assign(Root.Presentation.Slide);
        }

        private void SoundFile(string? filename)
        {
            var soundfile = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Media\" + filename);
            if (File.Exists(soundfile))
            {
                videoPlayer.Stop();
                fragmentPlayed = false;
                videoPlayer.Source = new Uri(soundfile);
                videoPlayer.Play();
                fragmentPlayed = true;
            }
        }

        private void buttonPlayFragment_Click(object sender, RoutedEventArgs e)
        {
            if (!fragmentPlayed)
            {
                SoundFile(model.SoundMinus);
                if (videoPlayer.HasAudio && model.Image == null)
                    soundImageFragment.Visibility = Visibility.Visible;
            }
            else
            {
                fragmentPlayed = false;
                videoPlayer.Stop();
                soundImageFragment.Visibility = Visibility.Collapsed;
            }
        }

        private void selectorButton_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (Root.Presentation.Slide is Slide slide)
            {
                soundImageFragment.Visibility = Visibility.Collapsed;
                if (soundImage.Visibility != Visibility.Visible &&
                    videoPlayer.Visibility != Visibility.Visible)
                {
                    model.Title = slide.Title;
                    model.Image = slide.Image;
                    soundImage.Visibility = Visibility.Visible;
                    SoundFile(model.Sound);
                }
                else if (soundImage.Visibility == Visibility.Visible)
                {
                    soundImage.Visibility = Visibility.Collapsed;
                    videoPlayer.Visibility = Visibility.Visible;
                    SoundFile(model.Video);
                }
                else if (videoPlayer.Visibility == Visibility.Visible)
                {
                    videoPlayer.Visibility = Visibility.Collapsed;
                    model.Title = "";
                    model.Image = null;
                    videoPlayer.Stop();
                    GotoNextSlide();
                }
            }
        }

        private void GotoNextSlide()
        {
            if (Root.Presentation.Slide is Slide slide)
            {
                if (slide.NextSlide())
                {
                    model.Assign(Root.Presentation.Slide);
                }
                else
                {
                    // TODO: финиш
                    mainFrame.Navigate(new PageEnding(mainFrame));
                }
            }
        }
    }
}
