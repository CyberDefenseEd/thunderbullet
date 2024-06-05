using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RuriLib;

namespace ThunderBullet.Views.Main.Settings
{
    /// <summary>
    /// Logica di interazione per OBSettings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        OBSettings OBSettingsPage = new OBSettings();
        RLSettings RLSettingsPage = new RLSettings();

        public Settings()
        {
            InitializeComponent();

            menuOptionRuriLib_MouseDown(this, null);
        }

        #region Menu Options MouseDown Events
        private void menuOptionRuriLib_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = RLSettingsPage;
            menuOptionSelected(menuOptionRuriLib);
        }

        private void menuOptionOpenBullet_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = OBSettingsPage;
            menuOptionSelected(menuOptionOpenBullet);
        }

        private void menuOptionSelected(object sender)
        {
            foreach (var child in topMenu.Children)
            {
                try
                {
                    var c = (Label)child;
                    c.Foreground = Utils.GetBrush("ForegroundMain");
                }
                catch { }
            }
            ((Label)sender).Foreground = Utils.GetBrush("ForegroundCustom");
        }
        #endregion

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            IOManager.SaveSettings(OB.rlSettingsFile, OB.Settings.RLSettings);
        }
    }
}
