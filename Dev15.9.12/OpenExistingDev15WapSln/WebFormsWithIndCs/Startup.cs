using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsWithIndCs.Startup))]
namespace WebFormsWithIndCs
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
