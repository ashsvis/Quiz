using System.Windows;
using System.Windows.Navigation;

namespace GuessMelody
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Root.Init();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageSlide(mainFrame));
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