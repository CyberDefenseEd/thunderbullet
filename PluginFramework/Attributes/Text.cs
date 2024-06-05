namespace PluginFramework.Attributes
{
    public class Text : InputField
    {
        public bool readOnly = false;

        public Text(string label, string tooltip = "") : base(label, tooltip) { }
    }
}
