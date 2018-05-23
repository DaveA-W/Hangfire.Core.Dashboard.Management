using System;

namespace Hangfire.Core.Dashboard.Management.Metadata
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
    public sealed class DisplayDataAttribute : Attribute
    {
        public string LabelText { get; set; }
        public string PlaceholderText { get; set; }
        public object DefaultValue { get; set; }

        public DisplayDataAttribute(string labelText, string placeholderText, object defaultValue = null)
        {
            this.LabelText = labelText;
            this.PlaceholderText = placeholderText;
            this.DefaultValue = defaultValue;
        }
    }
}