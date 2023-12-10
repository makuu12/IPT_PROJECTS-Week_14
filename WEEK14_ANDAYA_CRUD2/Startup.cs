using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEEK14_ANDAYA_CRUD2.Startup))]
namespace WEEK14_ANDAYA_CRUD2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
