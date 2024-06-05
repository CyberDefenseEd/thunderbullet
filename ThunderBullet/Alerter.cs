﻿using System.Windows;
using RuriLib.Interfaces;

namespace ThunderBullet
{
    public class Alerter : IAlerter
    {
        public bool YesOrNo(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButton.YesNo) == MessageBoxResult.Yes;
        }
    }
}
