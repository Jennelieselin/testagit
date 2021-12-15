using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testagit.Startup))]
namespace testagit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
