using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCpractice.Startup))]
namespace MVCpractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
