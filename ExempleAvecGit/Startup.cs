using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExempleAvecGit.Startup))]
namespace ExempleAvecGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
