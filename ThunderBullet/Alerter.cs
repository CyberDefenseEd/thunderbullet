using System.Windows;
using RuriLib.Interfaces;

namespace ThunderBullet
{
    public class Alerter : IAlerter
    {
        public bool YesOrNo(string message, string title)
        {
            var dialog = new Dialog(message, title);
            dialog.ShowDialog();
            return dialog.Result;
        }
    }
}
