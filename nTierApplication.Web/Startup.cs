using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nTierApplication.Web.Startup))]
namespace nTierApplication.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
