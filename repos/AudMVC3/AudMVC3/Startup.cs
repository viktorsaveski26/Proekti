using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AudMVC3.Startup))]
namespace AudMVC3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
