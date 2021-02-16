using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineStoreWebApp.Startup))]
namespace OnlineStoreWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
