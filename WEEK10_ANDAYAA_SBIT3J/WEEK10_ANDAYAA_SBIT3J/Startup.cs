using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEEK10_ANDAYAA_SBIT3J.Startup))]
namespace WEEK10_ANDAYAA_SBIT3J
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
