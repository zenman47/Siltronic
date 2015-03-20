using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiveCensus1.Startup))]
namespace LiveCensus1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
