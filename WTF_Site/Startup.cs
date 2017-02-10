using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WTF_Site.Startup))]
namespace WTF_Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
