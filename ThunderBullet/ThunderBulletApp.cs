using RuriLib.Interfaces;

namespace ThunderBullet
{
    public struct ThunderBulletApp : IApplication
    {
        public IRunnerManager RunnerManager { get; set; }
        public IProxyManager ProxyManager { get; set; }
        public IProxyChecker ProxyChecker { get; set; }
        public IWordlistManager WordlistManager { get; set; }
        public IConfigManager ConfigManager { get; set; }
        public IHitsDB HitsDB { get; set; }
        public IAlerter Alerter { get; set; }
        public ILogger Logger { get; set; }
        public ISettings Settings { get; set; }
    }
}
