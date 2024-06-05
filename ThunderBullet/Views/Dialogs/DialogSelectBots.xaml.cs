using System.Windows;
using System.Windows.Controls;
using RuriLib.Runner;

namespace ThunderBullet
{
    /// <summary>
    /// Logica di interazione per DialogSelectBots.xaml
    /// </summary>
    public partial class DialogSelectBots : Page
    {
        public object Caller { get; set; }

        public DialogSelectBots(object caller, int initial = 1)
        {
            InitializeComponent();
            Caller = caller;
            botsNumberTextbox.Text = initial.ToString();
        }

        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            int bots = 1;
            int.TryParse(botsNumberTextbox.Text, out bots);

            if (Caller.GetType() == typeof(RunnerViewModel))
            {
                (Caller as RunnerViewModel).BotsAmount = bots;
            }
            ((MainDialog)Parent).Close();
        }
    }
}
