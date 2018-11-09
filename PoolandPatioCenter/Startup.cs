using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoolandPatioCenter.Startup))]
namespace PoolandPatioCenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
