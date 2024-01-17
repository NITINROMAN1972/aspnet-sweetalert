using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SweetAlert.Startup))]
namespace SweetAlert
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
