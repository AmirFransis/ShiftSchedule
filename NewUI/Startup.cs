using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewUI.Startup))]
namespace NewUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
