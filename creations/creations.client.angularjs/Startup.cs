using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(creations.client.angularjs.Startup))]
namespace creations.client.angularjs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
