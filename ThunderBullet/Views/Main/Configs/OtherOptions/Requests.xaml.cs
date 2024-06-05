﻿using System.Windows.Controls;

namespace ThunderBullet.Views.Main.Configs.OtherOptions
{
    /// <summary>
    /// Logica di interazione per Requests.xaml
    /// </summary>
    public partial class Requests : Page
    {
        public Requests()
        {
            InitializeComponent();
            DataContext = OB.ConfigManager.CurrentConfig.Config.Settings;
        }
    }
}
