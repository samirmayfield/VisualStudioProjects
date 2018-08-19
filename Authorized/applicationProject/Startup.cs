using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(applicationProject.Startup))]
namespace applicationProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
