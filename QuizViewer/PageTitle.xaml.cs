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
    /// Логика взаимодействия для PageTitle.xaml
    /// </summary>
    public partial class PageTitle : Page
    {
        private readonly Frame mainFrame;

        public PageTitle(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //mePlayer.Play();
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageQuestion(mainFrame));
        }
    }
}
