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
        //nu testar jag bara skriva en kommentar här för att se om det syns!
    }
}
