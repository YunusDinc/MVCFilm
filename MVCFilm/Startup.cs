using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFilm.Startup))]
namespace MVCFilm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
