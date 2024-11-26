using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_7_Elephant.Startup))]
namespace _7_Elephant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
