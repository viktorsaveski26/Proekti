using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication31.Startup))]
namespace WebApplication31
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
