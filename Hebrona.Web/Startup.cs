using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hebrona.Web.Startup))]
namespace Hebrona.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
