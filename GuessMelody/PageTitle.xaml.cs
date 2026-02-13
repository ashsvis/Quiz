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

        private void selectorButton_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (Root.Presentation.Slide is Slide slide)
            {
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
