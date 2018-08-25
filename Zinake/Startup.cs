using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zinake.Startup))]
namespace Zinake
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
