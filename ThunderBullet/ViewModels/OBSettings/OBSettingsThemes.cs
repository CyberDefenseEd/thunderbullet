using System.Collections.Generic;
using System.Reflection;
using RuriLib.ViewModels;

namespace OpenBullet.ViewModels
{
    public class OBSettingsThemes : ViewModelBase
    {
        // BACKGROUND
        private string backgroundMain = "#0d0d0c";
        public string BackgroundMain { get { return backgroundMain; } set { backgroundMain = value; OnPropertyChanged(); } }
        private string backgroundSecondary = "#1f1f1f";
        public string BackgroundSecondary { get { return backgroundSecondary; } set { backgroundSecondary = value; OnPropertyChanged(); } }

        // FOREGROUND
        private string foregroundMain = "#e3e3e3";
        public string ForegroundMain { get { return foregroundMain; } set { foregroundMain = value; OnPropertyChanged(); } }
        private string foregroundGood = "#b1ffa4";
        public string ForegroundGood { get { return foregroundGood; } set { foregroundGood = value; OnPropertyChanged(); } }
        private string foregroundBad = "#ffa4ac";
        public string ForegroundBad { get { return foregroundBad; } set { foregroundBad = value; OnPropertyChanged(); } }
        private string foregroundFree = "#ffc9a4";
        public string ForegroundCustom { get { return foregroundFree; } set { foregroundFree = value; OnPropertyChanged(); } }
        private string foregroundRetry = "#fffda4";
        public string ForegroundRetry { get { return foregroundRetry; } set { foregroundRetry = value; OnPropertyChanged(); } }
        private string foregroundToCheck = "#a4e8ff";
        public string ForegroundToCheck { get { return foregroundToCheck; } set { foregroundToCheck = value; OnPropertyChanged(); } }
        private string foregroundMenuSelected = "#5865f2";
        public string ForegroundMenuSelected { get { return foregroundMenuSelected; } set { foregroundMenuSelected = value; OnPropertyChanged(); } }

        // IMAGES
        private bool useImage = false;
        public bool UseImage { get { return useImage; } set { useImage = value; OnPropertyChanged(); } }
        private string backgroundImage = "";
        public string BackgroundImage { get { return backgroundImage; } set { backgroundImage = value; OnPropertyChanged(); } }
        private int backgroundImageOpacity = 100;
        public int BackgroundImageOpacity { get { return backgroundImageOpacity; } set { backgroundImageOpacity = value; OnPropertyChanged(); } }
        private string backgroundLogo = "";
        public string BackgroundLogo { get { return backgroundLogo; } set { backgroundLogo = value; OnPropertyChanged(); } }

        private bool enableSnow = false;
        public bool EnableSnow { get { return enableSnow; } set { enableSnow = value; OnPropertyChanged(); } }
        private int snowAmount = 100;
        public int SnowAmount { get { return snowAmount; } set { snowAmount = value; OnPropertyChanged(); } }
        private bool allowTransparency = false;
        public bool AllowTransparency { get { return allowTransparency; } set { allowTransparency = value; OnPropertyChanged(); } }

        public void Reset()
        {
            OBSettingsThemes def = new OBSettingsThemes();
            IList<PropertyInfo> props = new List<PropertyInfo>(typeof(OBSettingsThemes).GetProperties());

            foreach (PropertyInfo prop in props)
            {
                prop.SetValue(this, prop.GetValue(def, null));
            }
        }
    }
}
