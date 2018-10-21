using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMemberships.Startup))]
namespace MVCMemberships
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
