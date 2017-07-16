using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestaoComercioPISO.WebSite.Startup))]
namespace GestaoComercioPISO.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
