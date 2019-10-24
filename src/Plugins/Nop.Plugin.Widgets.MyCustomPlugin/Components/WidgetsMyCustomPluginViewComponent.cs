using System;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Plugin.Widgets.MyCustomPlugin.Models;
using Nop.Services.Configuration;
using Nop.Services.Media;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.MyCustomPlugin.Components
{
    [ViewComponent(Name = "WidgetsMyCustomPlugin")]
    public class WidgetsMyCustomPluginViewComponent : NopViewComponent
    {
        public static string ViewComponentName => "WidgetsMyCustomPlugin";
        private readonly IStoreContext _storeContext;
        private readonly ISettingService _settingService;

        public WidgetsMyCustomPluginViewComponent(IStoreContext storeContext, ISettingService settingService)
        {
            this._storeContext = storeContext;
            this._settingService = settingService;
        }

        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            var MyCustomPluginSettings = _settingService.LoadSetting<MyCustomPluginSettings>(_storeContext.CurrentStore.Id);

            var model = new PublicInfoModel
            {
                Message = MyCustomPluginSettings.Message,
                UseSandbox = MyCustomPluginSettings.UseSandbox
            };

            if (!model.UseSandbox && string.IsNullOrEmpty(model.Message))
                //no Use Sandbox
                return Content("");

            return View("~/Plugins/Widgets.MyCustomPlugin/Views/PublicInfo.cshtml", model);
        }
    }
}
