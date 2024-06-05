using System.Windows.Controls;
using RuriLib;

namespace OpenBullet.Views.StackerBlocks
{
    /// <summary>
    /// Logica di interazione per PageBlockCaptcha.xaml
    /// </summary>
    public partial class PageBlockCaptcha : Page
    {
        BlockImageCaptcha vm;

        public PageBlockCaptcha(BlockImageCaptcha block)
        {
            InitializeComponent();
            vm = block;
            DataContext = vm;
        }
    }
}
