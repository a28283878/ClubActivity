using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClubActivity.Startup))]
namespace ClubActivity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
