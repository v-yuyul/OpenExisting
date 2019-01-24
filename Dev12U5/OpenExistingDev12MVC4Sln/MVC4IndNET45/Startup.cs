using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC4IndNET45.Startup))]
namespace MVC4IndNET45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
