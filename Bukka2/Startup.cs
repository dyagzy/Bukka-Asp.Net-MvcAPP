using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bukka2.Startup))]
namespace Bukka2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
