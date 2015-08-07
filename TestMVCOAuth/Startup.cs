using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCOAuth.Startup))]
namespace TestMVCOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
