using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeSchedulingSystem.Startup))]
namespace TimeSchedulingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
