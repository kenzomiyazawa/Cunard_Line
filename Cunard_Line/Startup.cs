using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cunard_Line.Startup))]
namespace Cunard_Line
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
