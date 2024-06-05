using System.Windows.Controls;
using RuriLib;

namespace ThunderBullet.Views.StackerBlocks
{
    /// <summary>
    /// Logica di interazione per PageSBlockNavigate.xaml
    /// </summary>
    public partial class PageSBlockNavigate : Page
    {
        SBlockNavigate vm;

        public PageSBlockNavigate(SBlockNavigate block)
        {
            InitializeComponent();
            vm = block;
            DataContext = vm;
        }
    }
}
