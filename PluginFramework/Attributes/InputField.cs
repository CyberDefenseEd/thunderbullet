using System;

namespace PluginFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class InputField : Attribute
    {
        public string label;
        public string tooltip;

        public InputField(string label, string tooltip = "")
        {
            this.label = label;
            this.tooltip = tooltip;
        }
    }
}
