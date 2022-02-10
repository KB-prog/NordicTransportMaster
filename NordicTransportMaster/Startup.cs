using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NordicTransportMaster.Startup))]
namespace NordicTransportMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
