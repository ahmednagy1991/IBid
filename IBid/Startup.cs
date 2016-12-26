using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IBid.Startup))]
namespace IBid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
