using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubVS2013TSP.Startup))]
namespace GithubVS2013TSP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
