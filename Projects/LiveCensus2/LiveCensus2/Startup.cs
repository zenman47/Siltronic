using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiveCensus2.Startup))]
namespace LiveCensus2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
