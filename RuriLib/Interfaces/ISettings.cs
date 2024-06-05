using RuriLib.Models;
using RuriLib.ViewModels;

namespace RuriLib.Interfaces
{
    /// <summary>
    /// An interface for global settings.
    /// </summary>
    public interface ISettings
    {
        /// <summary>
        /// The current Environment settings.
        /// </summary>
        EnvironmentSettings Environment { get; }

        /// <summary>
        /// The current RuriLib settings.
        /// </summary>
        RLSettingsViewModel RLSettings { get; }
    }
}
