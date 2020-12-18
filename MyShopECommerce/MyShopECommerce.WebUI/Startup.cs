using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopECommerce.WebUI.Startup))]
namespace MyShopECommerce.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
