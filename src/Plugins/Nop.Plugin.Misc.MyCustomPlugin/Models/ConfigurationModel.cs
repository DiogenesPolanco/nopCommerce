using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Widgets.MyCustomPlugin.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        [NopResourceDisplayName("Plugin.Widgets.MyCustomPlugin.UseSandbox")]
        public bool UseSandbox { get; set; }
        [NopResourceDisplayName("Plugin.Widgets.MyCustomPlugin.Message")]
        public string Message { get; set; }
    }
}