using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestIndentity.Startup))]
namespace TestIndentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
