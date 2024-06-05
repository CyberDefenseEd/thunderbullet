using System;

namespace PluginFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class Button : Attribute
    {
        public string text;

        public Button(string text)
        {
            this.text = text;
        }
    }
}
