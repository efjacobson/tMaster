using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tMaster.Startup))]
namespace tMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
