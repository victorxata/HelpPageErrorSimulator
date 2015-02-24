using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelpPageErrorSimulator.Startup))]
namespace HelpPageErrorSimulator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
