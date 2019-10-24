using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Plugin.Widgets.MyCustomPlugin.Models;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Media;
using Nop.Services.Messages;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Widgets.MyCustomPlugin.Controllers
{
    [Area(AreaNames.Admin)]
    public class MyCustomPluginController : BasePluginController
    {
        private readonly ILocalizationService _localizationService;
        private readonly INotificationService _notificationService;
        private readonly IPermissionService _permissionService;
        private readonly IPictureService _pictureService;
        private readonly ISettingService _settingService;
        private readonly IStoreContext _storeContext;

        public MyCustomPluginController(ILocalizationService localizationService,
            INotificationService notificationService,
            IPermissionService permissionService,
            IPictureService pictureService,
            ISettingService settingService,
            IStoreContext storeContext)
        {
            this._localizationService = localizationService;
            this._notificationService = notificationService;
            this._permissionService = permissionService;
            this._pictureService = pictureService;
            this._settingService = settingService;
            this._storeContext = storeContext;
        }

        public IActionResult Configure()
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();

            //load settings for a chosen store scope
            var storeScope = _storeContext.ActiveStoreScopeConfiguration;
            var MyCustomPluginSettings = _settingService.LoadSetting<MyCustomPluginSettings>(storeScope);
            var model = new ConfigurationModel
            {
                Message = MyCustomPluginSettings.Message,
                UseSandbox = MyCustomPluginSettings.UseSandbox
            };

            return View("~/Plugins/Widgets.MyCustomPlugin/Views/Configure.cshtml", model);
        }

        [HttpPost]
        public IActionResult Configure(ConfigurationModel model)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();

            //load settings for a chosen store scope
            var storeScope = _storeContext.ActiveStoreScopeConfiguration;
            var MyCustomPluginSettings = _settingService.LoadSetting<MyCustomPluginSettings>(storeScope);
             
            MyCustomPluginSettings.Message = model.Message;
            MyCustomPluginSettings.UseSandbox = model.UseSandbox;

            /* We do not clear cache after each setting update.
             * This behavior can increase performance because cached settings will not be cleared 
             * and loaded from database after each update */
            _settingService.SaveSetting(MyCustomPluginSettings, x => x.Message, storeScope, false);
            _settingService.SaveSetting(MyCustomPluginSettings, x => x.UseSandbox, storeScope, false);

            //now clear settings cache
            _settingService.ClearCache();
             
            _notificationService.SuccessNotification(_localizationService.GetResource("Admin.Plugins.Saved"));
            return Configure();
        }
    }
}