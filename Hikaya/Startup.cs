using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hikaya.Startup))]
namespace Hikaya
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
