using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eShop.WebUI.Startup))]
namespace eShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
