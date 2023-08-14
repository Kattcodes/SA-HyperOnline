using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ul.Startup))]
namespace Ul
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
