using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EF_web.Startup))]
namespace EF_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
