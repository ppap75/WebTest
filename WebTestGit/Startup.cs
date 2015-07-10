using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTestGit.Startup))]
namespace WebTestGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
