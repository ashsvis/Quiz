using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GuessMelody
{
    /// <summary>
    /// Логика взаимодействия для PageTitle.xaml
    /// </summary>
    public partial class PageTitle : Page
    {
        private readonly Frame mainFrame;
        private readonly PageTitleModel model;

        public PageTitle(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
            model = (PageTitleModel)DataContext;
            soundPlayer.MediaOpened += SoundPlayer_MediaOpened;
            soundPlayer.MediaEnded += SoundPlayer_MediaEnded;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            model.Assign(Root.Presentation.FirstSlide);
            SoundFile("opening2013.mp3");
        }

        private void SoundPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            //model.Enabled = false;
        }

        private void SoundPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            //model.Enabled = true;
            //if (actions.Count > 0)
            //{
            //    var action = actions.Dequeue();
            //    action.Invoke();
            //}
        }

        private void SoundFile(string filename)
        {
            var soundfile = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Media\" + filename);
            if (File.Exists(soundfile))
            {
                soundPlayer.Stop();
                soundPlayer.Source = new Uri(soundfile);
                soundPlayer.Play();
            }
        }

        private void buttonPlayFragment_Click(object sender, RoutedEventArgs e)
        {
            SoundFile("Мария Пахоменко - Стоят Девчонки (минус).mp3");
        }
    }
}
