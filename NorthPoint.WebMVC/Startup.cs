using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthPoint.WebMVC.Startup))]
namespace NorthPoint.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
