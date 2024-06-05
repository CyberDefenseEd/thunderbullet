using OpenBullet.Plugins;
using RuriLib.ViewModels;

namespace OpenBullet.Views.UserControls
{
    /// <summary>
    /// Logica di interazione per UserControlInfoText.xaml
    /// </summary>
    public partial class UserControlInfoText : IControl
    {
        private ViewModelBase viewModel;

        public UserControlInfoText(string defaultValue, ViewModelBase viewModel = null)
        {
            InitializeComponent();
            DataContext = this;

            SetValue(defaultValue);

            this.viewModel = viewModel;
            if (viewModel != null)
            {
                viewModel.PropertyChanged += ViewModel_PropertyChanged;
            }
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            SetValue(viewModel.GetType().GetProperty(e.PropertyName).GetValue(viewModel));
        }

        public dynamic GetValue()
        {
            return valueLabel.Content;
        }

        public void SetValue(dynamic value)
        {
            valueLabel.Content = (string)value;
        }
    }
}
