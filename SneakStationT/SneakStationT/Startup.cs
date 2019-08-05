using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SneakStationT.Startup))]
namespace SneakStationT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
