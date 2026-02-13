using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Controls;

namespace GuessMelody
{
    /// <summary>
    /// Логика взаимодействия для PageIntro.xaml
    /// </summary>
    public partial class PageIntro : Page
    {
        private readonly Frame mainFrame;
        private readonly System.Media.SoundPlayer soundPlayer;

        public PageIntro(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            soundPlayer = new System.Media.SoundPlayer();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SoundResouceFile("opening2013.wav");
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

        private void introImage_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            soundPlayer.Stop();
            mainFrame.Navigate(new PageSlide(mainFrame));
        }
    }
}
