using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_PPC.Startup))]
namespace MVC_PPC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
