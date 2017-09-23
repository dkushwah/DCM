using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigitalCultivationMart.Startup))]
namespace DigitalCultivationMart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
