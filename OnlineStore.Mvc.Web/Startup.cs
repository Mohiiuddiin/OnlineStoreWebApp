using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineStore.Mvc.Web.Startup))]
namespace OnlineStore.Mvc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
