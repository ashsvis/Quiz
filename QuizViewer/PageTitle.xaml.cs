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

        public PageTitle(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            model = (PageTurnamentModel)DataContext;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //mePlayer.Play();
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            if (PageTurnamentModel.CurrentQuestion != null)
                mainFrame.Navigate(new PageQuestion(mainFrame));
        }

        private void Label_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // mePlayer.Stop();
            var videofile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Media\Запуск волчка.mp4");
            var soundfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Media\volchok.mp3");
            if (File.Exists(videofile) && File.Exists(soundfile))
                mainFrame.Navigate(new PagePlayVideo(this, 7f, videofile, mainFrame, false, soundfile));
        }
    }
}
