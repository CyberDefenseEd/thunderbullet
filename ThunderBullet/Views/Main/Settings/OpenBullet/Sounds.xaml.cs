using System.Windows.Controls;

namespace ThunderBullet.Views.Main.Settings.OpenBullet
{
    /// <summary>
    /// Logica di interazione per Sounds.xaml
    /// </summary>
    public partial class Sounds : Page
    {
        public Sounds()
        {
            InitializeComponent();
            DataContext = OB.OBSettings.Sounds;
        }
    }
}
