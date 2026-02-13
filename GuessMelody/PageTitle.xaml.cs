using System.IO;
using System.Media;
using System.Reflection;
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

        private readonly System.Media.SoundPlayer soundPlayer;
        private readonly Queue<Action> actions = [];

        public PageTitle(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            model = (PageTitleModel)DataContext;
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
            SoundResouceFile("opening2013.wav");
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

        private void SoundResouceFile(string? filename)
        {
            //get the current assembly
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            //load the embedded resource as a stream
            var name = string.Format("{0}.Resources.{1}", assembly.GetName().Name, filename);
            var stream = assembly.GetManifestResourceStream(name);
            //load the stream into the player
            soundPlayer.Stream = stream;
            //play the sound
            soundPlayer.Play();
        }

        private void buttonPlayFragment_Click(object sender, RoutedEventArgs e)
        {
            SoundFile(model.SoundMinus);
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
                }
            }
        }
    }
}
