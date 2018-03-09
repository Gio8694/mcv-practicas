using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Noticiero.Startup))]
namespace Noticiero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
