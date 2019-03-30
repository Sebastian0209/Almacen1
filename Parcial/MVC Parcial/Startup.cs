using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Parcial.Startup))]
namespace MVC_Parcial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
