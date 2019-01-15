using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MFEC.Presentation.Site.Startup))]
namespace MFEC.Presentation.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
