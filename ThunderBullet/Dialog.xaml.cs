using System.Windows;

namespace ThunderBullet
{
    public partial class Dialog : Window
    {
        public bool Result { get; private set; }

        public Dialog(string message, string title)
        {
            InitializeComponent();
            Title = title;
            MessageTextBlock.Text = message;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Result = true;
            Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            Result = false;
            Close();
        }
    }
}
