using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Buoi3.Startup))]
namespace Buoi3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
