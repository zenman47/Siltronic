using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiveCensus.Startup))]
namespace LiveCensus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
