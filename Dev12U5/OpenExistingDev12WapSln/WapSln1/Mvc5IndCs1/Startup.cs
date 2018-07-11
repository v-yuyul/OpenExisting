using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5IndCs1.Startup))]
namespace Mvc5IndCs1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
