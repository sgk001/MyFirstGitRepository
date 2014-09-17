using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstGitWebApplication.Startup))]
namespace MyFirstGitWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
