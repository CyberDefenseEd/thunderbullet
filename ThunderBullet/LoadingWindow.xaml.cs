using System.Windows;
using System.Windows.Media.Animation;

namespace ThunderBullet
{
    /// <summary>
    /// Logica di interazione per LoadingWindow.xaml
    /// </summary>
    public partial class LoadingWindow : Window
    {
        public LoadingWindow()
        {
            InitializeComponent();
            ((Storyboard)FindResource("WaitStoryboard")).Begin();
        }
    }
}
