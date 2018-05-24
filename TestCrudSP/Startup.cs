using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestCrudSP.Startup))]
namespace TestCrudSP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
