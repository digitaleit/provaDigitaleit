using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(provaDigitaleit.Startup))]
namespace provaDigitaleit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
