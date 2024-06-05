namespace PluginFramework.Attributes
{
    public class TextMulti : InputField
    {
        public bool readOnly = false;

        public TextMulti(string label, string tooltip = "") : base(label, tooltip) { }
    }
}
