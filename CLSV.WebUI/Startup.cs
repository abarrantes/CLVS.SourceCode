using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CLVS.WebUI.Startup))]
namespace CLVS.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
