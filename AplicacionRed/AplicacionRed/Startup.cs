using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicacionRed.Startup))]
namespace AplicacionRed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
