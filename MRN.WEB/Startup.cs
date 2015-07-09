using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MRN.WEB.Startup))]
namespace MRN.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
