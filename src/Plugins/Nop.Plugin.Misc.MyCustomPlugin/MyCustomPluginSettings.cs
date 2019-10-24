using Nop.Core.Configuration;

namespace Nop.Plugin.Widgets.MyCustomPlugin
{
    public class MyCustomPluginSettings : ISettings
    {
        public bool UseSandbox { get; set; }
        public string Message { get; set; } 
    }
}