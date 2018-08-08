using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5WithIndCs.Startup))]
namespace MVC5WithIndCs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
