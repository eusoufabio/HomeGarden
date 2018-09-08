using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeGardenWebMVC_API.Startup))]
namespace HomeGardenWebMVC_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
