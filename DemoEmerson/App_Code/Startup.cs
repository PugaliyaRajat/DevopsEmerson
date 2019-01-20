using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoEmerson.Startup))]
namespace DemoEmerson
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
