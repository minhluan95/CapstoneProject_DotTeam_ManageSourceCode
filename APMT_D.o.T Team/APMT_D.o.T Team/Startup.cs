using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APMT_D.o.T_Team.Startup))]
namespace APMT_D.o.T_Team
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
