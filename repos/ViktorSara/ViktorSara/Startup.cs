using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViktorSara.Startup))]
namespace ViktorSara
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
