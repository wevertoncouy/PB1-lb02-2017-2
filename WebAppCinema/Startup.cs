using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppCinema.Startup))]
namespace WebAppCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
