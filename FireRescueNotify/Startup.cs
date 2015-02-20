using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FireRescueNotify.Startup))]
namespace FireRescueNotify
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
