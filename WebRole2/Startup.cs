using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebRole2.Startup))]
namespace WebRole2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
