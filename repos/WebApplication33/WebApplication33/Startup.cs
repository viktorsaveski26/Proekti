using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication33.Startup))]
namespace WebApplication33
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
