using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using OpenBullet.ViewModels;
using PluginFramework;
using RuriLib;
using RuriLib.Interfaces;

namespace OpenBullet
{
    public static class OB
    {
        public static IApplication App => new ThunderBulletApp()
        {
            RunnerManager = RunnerManager,
            ProxyManager = ProxyManager,
            ProxyChecker = ProxyManager,
            WordlistManager = WordlistManager,
            ConfigManager = ConfigManager,
            HitsDB = HitsDB,
            Settings = Settings,
            Logger = Logger,
            Alerter = Alerter
        };

        public static string Version => "v1.0.0";

        // Block Mappings (including Plugins)
        public static List<(Type, Type, Color)> BlockMappings = new List<(Type, Type, Color)>();

        // Block Plugins
        // HACK: Find a better way to do this and a better place to put them
        public static List<IBlockPlugin> BlockPlugins;
        public static IEnumerable<BlockBase> BlockPluginsAsBase => BlockPlugins.Cast<BlockBase>();

        // Windows
        // TODO: Remove these from here, everything should only depend on the ViewModels not on the Views!
        public static MainWindow MainWindow { get; set; }
        public static LogWindow LogWindow { get; set; }

        // ViewModels
        public static RunnerManagerViewModel RunnerManager { get; set; }
        public static ProxyManagerViewModel ProxyManager { get; set; }
        public static WordlistManagerViewModel WordlistManager { get; set; }
        public static ConfigManagerViewModel ConfigManager { get; set; }
        public static StackerViewModel Stacker { get; set; }
        public static HitsDBViewModel HitsDB { get; set; }
        public static Alerter Alerter { get; set; } = new Alerter();
        public static LoggerViewModel Logger { get; set; } = new LoggerViewModel();
        public static GlobalSettings Settings { get; set; } = new GlobalSettings();
        public static OBSettingsViewModel OBSettings { get; set; }

        // Constant file paths
        public static readonly string dataBaseFile = @"database/OpenBullet.db";
        public static readonly string dataBaseBackupFile = @"database/OpenBullet-BackupCopy.db";
        public static readonly string obSettingsFile = @"settings/OBSettings.json";
        public static readonly string rlSettingsFile = @"settings/RLSettings.json";
        public static readonly string proxyManagerSettingsFile = @"settings/ProxyManagerSettings.json";
        public static readonly string envFile = @"settings/Environment.ini";
        public static readonly string licenseFile = @"settings/License.txt";
        public static readonly string logFile = @"Log.txt";
        public static readonly string configFolder = @"configs";
        public static readonly string pluginsFolder = @"plugins";
        public static readonly string defaultProxySiteUrl = "https://google.com";
        public static readonly string defaultProxyKey = "title>Google";
    }
}
