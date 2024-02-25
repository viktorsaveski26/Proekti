using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication34.Startup))]
namespace WebApplication34
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
