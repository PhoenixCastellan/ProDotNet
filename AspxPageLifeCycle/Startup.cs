using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspxPageLifeCycle.Startup))]
namespace AspxPageLifeCycle
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
