using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlmDJLWebApp.Startup))]
namespace AlmDJLWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
