using RuriLib.ViewModels;

namespace RuriLib.Models
{
    /// <summary>
    /// Objects that can be saved on a persistent storage can inherit from this class.
    /// </summary>
    public abstract class Persistable<T> : ViewModelBase
    {
        /// <summary>
        /// The unique id.
        /// </summary>
        public T Id { get; set; }
    }
}
