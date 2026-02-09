using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageTitle(mainFrame));
        }

        private void mainFrame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            //var ta = new ThicknessAnimation
            //{
            //    Duration = TimeSpan.FromSeconds(0.3),
            //    DecelerationRatio = 0.7,
            //    To = new Thickness(0, 0, 0, 0)
            //};
            //if (e.NavigationMode == NavigationMode.New)
            //{
            //    ta.From = new Thickness(0, 0, 1360, 0);
            //}
            //else if (e.NavigationMode == NavigationMode.Back)
            //{
            //    ta.From = new Thickness(1360, 0, 0, 0);
            //}
            //if (e.Content is Page page)
            //    page.BeginAnimation(MarginProperty, ta);
        }
    }
}