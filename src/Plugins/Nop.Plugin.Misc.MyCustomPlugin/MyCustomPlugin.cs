using Microsoft.AspNetCore.Routing;
using Nop.Core;
using Nop.Core.Plugins;
using Nop.Plugin.Widgets.MyCustomPlugin;
using Nop.Plugin.Widgets.MyCustomPlugin.Components;
using Nop.Services.Cms;
using Nop.Services.Common;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Web.Framework.Infrastructure;
using Nop.Web.Framework.Menu;
using System.Collections.Generic;
using System.Linq;

namespace Nop.Plugin.Widgets.MyCustomPlugin
{
    public class MyCustomPlugin : BasePlugin, IWidgetPlugin, IAdminMenuPlugin
    {
        private readonly ISettingService _settingService;
        private readonly IWebHelper _webHelper;
        private readonly ILocalizationService _localizationService;
        public MyCustomPlugin(ISettingService settingService, IWebHelper webHelper, ILocalizationService localizationService)
        {
            this._webHelper = webHelper;
            this._settingService = settingService;
            this._localizationService = localizationService; 
        }
        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/MyCustomPlugin/Configure";
        }
        public IList<string> GetWidgetZones()
        {
            return new List<string> { PublicWidgetZones.HomePageTop };
        }
         
        public string GetWidgetViewComponentName(string widgetZone)
        {
            return WidgetsMyCustomPluginViewComponent.ViewComponentName;
        }
        public override void Install()
        {
            var settings = new MyCustomPluginSettings()
            {
                UseSandbox = true,
                Message = "Hello World"
            };
            _settingService.SaveSetting(settings);

            _localizationService.AddOrUpdatePluginLocaleResource("Plugin.Widgets.MyCustomPlugin.UseSandbox", "UseSandbox");
            _localizationService.AddOrUpdatePluginLocaleResource("Plugin.Widgets.MyCustomPlugin.Message", "Message");
            base.Install();
        }

        public override void Uninstall()
        {
            _localizationService.DeletePluginLocaleResource("Plugin.Widgets.MyCustomPlugin.UseSandbox");
            _localizationService.DeletePluginLocaleResource("Plugin.Widgets.MyCustomPlugin.Message");
            base.Uninstall();
        }

        public void ManageSiteMap(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode()
            {
                SystemName = "MyCustomPlugin",
                Title = "MyCustomPlugin Title",
                ControllerName = "MyCustomPlugin",
                ActionName = "Configure",
                Visible = true,
                RouteValues = new RouteValueDictionary() { { "area", "Admin" } },
            };
            var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Third party plugins");
            if (pluginNode != null)
                pluginNode.ChildNodes.Add(menuItem);
            else
                rootNode.ChildNodes.Add(menuItem);
        }
    }
}