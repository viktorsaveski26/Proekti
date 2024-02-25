using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication35.Startup))]
namespace WebApplication35
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
