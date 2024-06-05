using System.Windows;
using System.Windows.Controls;
using RuriLib.Runner;

namespace OpenBullet
{
    /// <summary>
    /// Logica di interazione per DialogSetProxies.xaml
    /// </summary>
    public partial class DialogSetProxies : Page
    {
        public object Caller { get; set; }

        public DialogSetProxies(object caller)
        {
            InitializeComponent();
            Caller = caller;

            proxiesDefaultRadio.IsChecked = true;
        }

        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            ProxyMode mode = ProxyMode.Default;
            if ((bool)proxiesDefaultRadio.IsChecked) mode = ProxyMode.Default;
            else if ((bool)proxiesOnRadio.IsChecked) mode = ProxyMode.On;
            else if ((bool)proxiesOffRadio.IsChecked) mode = ProxyMode.Off;

            if (Caller.GetType() == typeof(RunnerViewModel))
            {
                (Caller as RunnerViewModel).ProxyMode = mode;
            }
            ((MainDialog)Parent).Close();
        }
    }
}
