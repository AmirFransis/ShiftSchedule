using Microsoft.Owin;
using Owin;
using ShiftSchedule.NewUI;

[assembly: OwinStartup(typeof(Startup))]
namespace ShiftSchedule.NewUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
