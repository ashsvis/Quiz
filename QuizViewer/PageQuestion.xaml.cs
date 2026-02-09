using System;
using System.Collections.Generic;
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

namespace QuizViewer
{
    /// <summary>
    /// Логика взаимодействия для PageQuestion.xaml
    /// </summary>
    public partial class PageQuestion : Page
    {
        private readonly Frame mainFrame;

        public PageQuestion(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //mePlayer.Play();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageQuestion(mainFrame));
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageQuestion(mainFrame));
        }

        private void btnBack_MouseEnter(object sender, MouseEventArgs e)
        {
            btnBack.Visibility = Visibility.Visible;
        }

        private void btnBack_MouseLeave(object sender, MouseEventArgs e)
        {
            btnBack.Visibility = Visibility.Hidden;
        }

        private void btnForward_MouseEnter(object sender, MouseEventArgs e)
        {
            btnForward.Visibility = Visibility.Visible;
        }

        private void btnForward_MouseLeave(object sender, MouseEventArgs e)
        {
            btnForward.Visibility = Visibility.Hidden;
        }
    }
}
