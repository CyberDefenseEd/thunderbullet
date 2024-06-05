namespace PluginFramework.Attributes
{
    public class Numeric : InputField
    {
        public int minimum = int.MinValue;
        public int maximum = int.MaxValue;

        public Numeric(string label, string tooltip = "") : base(label, tooltip) { }
    }
}
