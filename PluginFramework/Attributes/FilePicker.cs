namespace PluginFramework.Attributes
{
    public class FilePicker : InputField
    {
        public string filter = "Text Files|*.txt";

        public FilePicker(string label, string tooltip = "") : base(label, tooltip) { }
    }
}
