using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigitalRetailers.Startup))]
namespace DigitalRetailers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
