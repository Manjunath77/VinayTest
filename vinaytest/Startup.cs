using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vinaytest.Startup))]
namespace vinaytest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
