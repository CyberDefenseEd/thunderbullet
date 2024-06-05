using System.Windows.Controls;

namespace ThunderBullet.Views.Main.Configs.OtherOptions
{
    /// <summary>
    /// Logica di interazione per Selenium.xaml
    /// </summary>
    public partial class Selenium : Page
    {
        public Selenium()
        {
            InitializeComponent();
            DataContext = OB.ConfigManager.CurrentConfig.Config.Settings;
        }
    }
}
