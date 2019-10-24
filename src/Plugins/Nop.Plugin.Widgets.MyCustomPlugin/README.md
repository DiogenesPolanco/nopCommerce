<!-- wp:heading {"level":4} -->
<h4><strong>How to write a plugin for nopCommerce</strong></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>The add-ons are specialized modules which maximize the functionality of nopcommerce such as payment processors, shipping provider, etc. Currently you can take advantage of their official documentation by entering this <strong><a href="https://docs.nopcommerce.com/developer/plugins/how-to-write-plugin_4.00.html">link</a>.</strong></p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4><strong>Before launching the code, it is necessary to know the following of nopcommerce:</strong></h4>
<!-- /wp:heading -->

<!-- wp:list -->
<ul><li>Architecture of nopCommerce</li><li>Types of plugin  </li><li>Register new routes</li><li>The plugin structure, required files, and locations</li><li>Understanding Layout / Design</li><li>Handling "Install" and "Uninstall" methods</li><li>Handling requests. Controllers, models and views</li></ul>
<!-- /wp:list -->

<!-- wp:heading {"level":4} -->
<h4>Architecture of nopCommerce</h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>It is an open source e-commerce, so you can download from <a href="https://github.com/nopSolutions/nopCommerce">github </a>without any inconvenience and even collaborate. Projects and folders are listed in the order in which they appear in Visual Studio. The recommendation is not to change the source code of the libraries of the solution framework.</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4 id="librariesnopcore"><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Libraries/Nop.Core">\Libraries\Nop.Core</a></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>The Nop.Core project contains a set of core classes for nopCommerce, such as caching, events, helpers, and business objects (for example, Order and Customer entities).</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4 id="librariesnopdata"><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Libraries/Nop.Data">\Libraries\Nop.Data</a></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>The Nop.Data project contains a set of classes and functions for reading from and writing to a database or other data store. It helps separate data-access logic from your business objects.  </p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4 id="librariesnopservices"><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Libraries/Nop.Services">\Libraries\Nop.Services</a></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>This project contains a set of core services, business logic, validations or calculations related with the data, if needed. Some people call it Business Access Layer (BAL).</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4 id="projects-into-plugins-solution-folder"><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Plugins">Projects into \</a><strong><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Plugins">Plugins\</a></strong><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Plugins"> solution folder</a></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p><code>\Plugins</code>&nbsp;is a Visual Studio solution folder that contains plugin projects. Physically it's located in the root of your solution. But plugins DLLs are automatically copied in&nbsp;<code>\Presentation\Nop.Web\Plugins\</code>&nbsp;directory which is used for already deployed plugins because the build output paths of all plugins are set to&nbsp;<code>..\..\Presentation\Nop.Web\Plugins\{Group}.{Name}\</code>. This allows plugins to contain some external files, such as static content (CSS or JS files) without having to copy files between projects to be able to run the project.</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4 id="presentationnopweb"><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Presentation/Nop.Web">\Presentation\Nop.Web</a></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p><code>Nop.Web</code>&nbsp;is an MVC web application project, a presentation layer for public store which also contains administration panel included as an area. If you haven't used&nbsp;<code>ASP.NET</code>&nbsp;before, please find more info&nbsp;<a href="http://www.asp.net/">here</a>. This is the application that you actually run. It is the startup project of the application.</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4 id="presentationnopwebframework"><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Presentation/Nop.Web.Framework">\Presentation\Nop.Web.Framework</a></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>Nop.Web.Framework is a class library project containing some common presentation things for&nbsp;<code>Nop.Web</code>&nbsp;project.</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4 id="testnopcoretests"><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Tests/Nop.Core.Tests">\Test\Nop.Core.Tests</a></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>Nop.Core.Tests is the test project for the Nop.Core project.</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4 id="testnopservicestests"><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Tests/Nop.Services.Tests">\Test\Nop.Services.Tests</a></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>Nop.Services.Tests is the test project for the Nop.Services project.</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4 id="testnoptests"><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Tests/Nop.Tests">\Test\Nop.Tests</a></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>Nop.Tests is a class library project containing some common test classes and helpers for other test projects. It does not have any test.</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4 id="testnopwebmvctests"><a href="https://github.com/nopSolutions/nopCommerce/tree/develop/src/Tests/Nop.Web.MVC.Tests">\Test\Nop.Web.MVC.Tests</a></h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>Nop.Web.MVC.Tests is the test project for the presentation layer projects.</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4>Types of plugin  </h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>The type of its complement is defined by the interface that implements the main complement class.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Discount Rules (IDiscountRequirementRule)</strong>For defining requirements that must be met my an order for a discount to be applied</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Exchange Rate Prodider (IExchangeRateProvider)</strong>For getting the exchange rates for currencies</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>External Authentication Method (IExternalAuthenticationMethod)</strong>For adding new external authentication methods (e.g. “Login with Facebook”)</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Widgets (IWidgetsPlugin)</strong>For when your plugin doesn’t fit any of the other types</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Payment Method (IPaymentMethod)</strong>For example, Paypal or Worldpay</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Shipping Rate Computation Method (IShippingRateComputationMethod)</strong>For calculating shipping rates (many plugins of this time call web services provided by couriers to retrieve rates)</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Pickup points</strong> is an option providing customers the flexibility to select a point where they can receive parcels.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Tax Provider (ITaxProvider)</strong>For calculating tax rates</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p><strong>Widget (IWidgetPlugin)</strong>Widgets are blocks of content shown throughout the site. The default theme contains many widget “areas”.<br>You can assign your new widget to one of these areas, and wherever the area is referenced in the theme, your widget will appear.</p>
<!-- /wp:paragraph -->

<!-- wp:heading {"level":4} -->
<h4>Register new routes</h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>ASP.NET Core routing is responsible for assigning incoming browser requests via a get to the MVC controller. NopCommerce has an IRouteProvider interface that is used for route registration during application startup. All main routes are registered in the RouteProvider class located in the Nop.Web project.</p>
<!-- /wp:paragraph -->

<!-- wp:html -->
<script src="https://gist.github.com/DiogenesPolanco/e95c0339a763e787b691e41a66ee67c9.js"></script>
<!-- /wp:html -->

<!-- wp:heading {"level":4} -->
<h4>The plugin structure, required files, and locations</h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>First thing you need to do is to create a new "Class Library" project in the solution. It's a good practice to place all plugins into&nbsp;<code>\Plugins</code>&nbsp;directory in the root of your solution (do not mix up with \Plugins subdirectory located in&nbsp;<code>\Nop.Web</code>&nbsp;directory which is used for already deployed plugins). It's a good practice to place all plugins into "Plugins" solution folder (you can find more information about solution folders&nbsp;<a href="http://msdn.microsoft.com/en-us/library/sx2027y2.aspx">here</a>).</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>A recommended name for a plugin project is "Nop.Plugin.{Group}.{Name}". {Group} is your plugin group (for example, "Payment" or "Shipping"). {Name} is your plugin name (for example, "PayPalStandard"). For example, PayPal Standard payment plugin has the following name: Nop.Plugin.Payments.PayPalStandard. But please note that it's not a requirement. And you can choose any name for a plugin. For example, "MyGreatPlugin".</p>
<!-- /wp:paragraph -->

<!-- wp:image {"id":434} -->
<figure class="wp-block-image"><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/Capture-6.png" alt="" class="wp-image-434"/></figure>
<!-- /wp:image -->

<!-- wp:paragraph -->
<p>Once the plugin project is created you have to open its&nbsp;<code>.csproj</code>&nbsp;file in any text editor and replace its content with the following one:</p>
<!-- /wp:paragraph -->

<!-- wp:html -->
<script src="https://gist.github.com/DiogenesPolanco/39adef3f6336ccb7e41e55788300c0af.js"></script>
<!-- /wp:html -->

<!-- wp:image {"id":330} -->
<figure class="wp-block-image"><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/nop-plugin-1.jpg" alt="" class="wp-image-330"/></figure>
<!-- /wp:image -->

<!-- wp:paragraph -->
<p>The next step is creating a&nbsp;<strong>&nbsp;plugin.json</strong> file required for each plugin. This file contains meta information describing your plugin. Just copy this file from any other existing plugin and modify it for your needs. For example, PayPal Standard payment plugin has the following&nbsp;<strong>plugin.json</strong>&nbsp;file:</p>
<!-- /wp:paragraph -->

<!-- wp:html -->
<script src="https://gist.github.com/DiogenesPolanco/3376af447b8583fa3eb8641fa7eae144.js"></script>
<!-- /wp:html -->

<!-- wp:paragraph -->
<p>Add a class&nbsp;<strong>MyCustomPlugin.cs</strong>&nbsp;and use the following code:&nbsp;</p>
<!-- /wp:paragraph -->

<!-- wp:image {"id":428} -->
<figure class="wp-block-image"><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/Capture-1-1024x440.png" alt="" class="wp-image-428"/></figure>
<!-- /wp:image -->

<!-- wp:html -->
<script src="https://gist.github.com/DiogenesPolanco/846b8e47055ad324157aafd776516ce8.js"></script>
<!-- /wp:html -->

<!-- wp:heading {"level":4} -->
<h4>Handling "Install" and "Uninstall" methods</h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>Some plugins can require additional logic during plugin installation. For example, a plugin can insert new locale resources. So open your IPlugin implementation (in most case it'll be derived from BasePlugin class) and override the following methods:</p>
<!-- /wp:paragraph -->

<!-- wp:list -->
<ul><li>Install. This method will be invoked during plugin installation. You can initialize any settings here, insert new locale resources, or create some new database tables (if required).</li><li>Uninstall. This method will be invoked during plugin uninstallation.</li></ul>
<!-- /wp:list -->

<!-- wp:html -->
<script src="https://gist.github.com/DiogenesPolanco/338b07a97d4cb6cd3c1b7b594dffb70f.js"></script>
<!-- /wp:html -->

<!-- wp:heading {"level":4} -->
<h4>Understanding Layout / Design</h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>What are layouts? Every web developer/designer wants to maintain a consistent look and feel across all of the pages within the website. Back in the days, the concept of "Master Pages" was introduced in ASP.NET 2.0 which helps in maintaining a consistent look of the website by mapping it with .aspx pages.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>Razor also supports this similar concept with a feature called "Layouts". Basically, it allows you to define a common site template and then inherit its look and feel across all the views/pages on your website.</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>In nopCommerce, there are 2 different kinds of layouts:</p>
<!-- /wp:paragraph -->

<!-- wp:list -->
<ul><li><code>_ColumnsOne.cshtml</code></li><li><code>_ColumnsTwo.cshtml</code></li></ul>
<!-- /wp:list -->

<!-- wp:paragraph -->
<p>All these 2 layouts are inherited from one main layout called:&nbsp;<code>_Root.cshtml</code>. The&nbsp;<code>_Root.cshtml</code>&nbsp;itself is inherited from&nbsp;<code>_Root.Head.cshtml</code>.&nbsp;<code>_Root.Head.cshtml</code>&nbsp;is the file you need to look into if you are linked css stylesheet and jquery files (you can add/link more&nbsp;<code>.css</code>&nbsp;and&nbsp;<code>.js</code>&nbsp;files here). The location of all these layouts in nopCommerce is as follows: nopCommerce root&nbsp;<code>directory/Views/Shared/...</code>. If you are using source code version then:&nbsp;<code>\Presentation\Nop.Web\Views\Shared\...</code></p>
<!-- /wp:paragraph -->

<!-- wp:gallery {"ids":[395,396,397,399],"columns":4} -->
<ul class="wp-block-gallery columns-4 is-cropped"><li class="blocks-gallery-item"><figure><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/root-layout.jpg" alt="" data-id="395" data-link="https://diogenespolanco.com/2019/10/22/how-to-write-a-plugin-for-nopcommerce/root-layout/" class="wp-image-395"/></figure></li><li class="blocks-gallery-item"><figure><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/root-layout-css.jpg" alt="" data-id="396" data-link="https://diogenespolanco.com/2019/10/22/how-to-write-a-plugin-for-nopcommerce/root-layout-css/" class="wp-image-396"/></figure></li><li class="blocks-gallery-item"><figure><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/column-one.jpg" alt="" data-id="397" data-link="https://diogenespolanco.com/2019/10/22/how-to-write-a-plugin-for-nopcommerce/column-one/" class="wp-image-397"/></figure></li><li class="blocks-gallery-item"><figure><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/column-two.jpg" alt="" data-id="399" data-link="https://diogenespolanco.com/2019/10/22/how-to-write-a-plugin-for-nopcommerce/column-two/" class="wp-image-399"/></figure></li></ul>
<!-- /wp:gallery -->

<!-- wp:heading {"level":4} -->
<h4>Handling requests. Controllers, models and views</h4>
<!-- /wp:heading -->

<!-- wp:paragraph -->
<p>Add a class MyCustomPluginController.cs (in folder “Controllers” within your plugin) and use the following code: &nbsp;&nbsp;</p>
<!-- /wp:paragraph -->

<!-- wp:image {"id":429} -->
<figure class="wp-block-image"><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/Capture-2.png" alt="" class="wp-image-429"/></figure>
<!-- /wp:image -->

<!-- wp:html -->
<script src="https://gist.github.com/DiogenesPolanco/5127bc288a3b8942729abb60ebe233fd.js"></script>
<!-- /wp:html -->

<!-- wp:paragraph -->
<p>Add a&nbsp;<strong>Configure.cshtml (View)</strong>&nbsp;– In this case we are creating a blank plugin.</p>
<!-- /wp:paragraph -->

<!-- wp:image {"id":430} -->
<figure class="wp-block-image"><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/Capture-3-1024x596.png" alt="" class="wp-image-430"/></figure>
<!-- /wp:image -->

<!-- wp:paragraph -->
<p>Now, we will add the menu item by adding this code in “MyCustomPlugin.cs”:</p>
<!-- /wp:paragraph -->

<!-- wp:html -->
<script src="https://gist.github.com/DiogenesPolanco/ce0ffb55e3cecf32b9b37b1e603b1410.js"></script>
<!-- /wp:html -->

<!-- wp:paragraph -->
<p>We can see our menu item here:</p>
<!-- /wp:paragraph -->

<!-- wp:image {"id":431} -->
<figure class="wp-block-image"><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/Capture-4.png" alt="" class="wp-image-431"/></figure>
<!-- /wp:image -->

<!-- wp:paragraph -->
<p>Let’s create a “WidgetsMyCustomPluginViewComponent” file inside the “Components” folder of your custom plugin and simply paste the default home view (PublicInfo.cshtml) from Nop.Web like this:</p>
<!-- /wp:paragraph -->

<!-- wp:html -->
<script src="https://gist.github.com/DiogenesPolanco/82ac7208350308e09dc7b26d790c99d4.js"></script>
<!-- /wp:html -->

<!-- wp:paragraph -->
<p><strong>Note:</strong>&nbsp;Make sure the output directory (in properties) for your home view (PublicInfo.cshtml) is defined as “Copy if newer”. Rebuild your plugin and try going to your public store (since your plugin is already installed)</p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>We should see the plugin view overriding the default home view like this:</p>
<!-- /wp:paragraph -->

<!-- wp:image {"id":432} -->
<figure class="wp-block-image"><img src="https://diogenespolanco.com/wp-content/uploads/2019/10/Capture-5-1024x727.png" alt="" class="wp-image-432"/></figure>
<!-- /wp:image -->
 
