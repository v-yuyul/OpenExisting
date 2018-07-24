using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsCsHTTP.Startup))]
namespace WebFormsCsHTTP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
