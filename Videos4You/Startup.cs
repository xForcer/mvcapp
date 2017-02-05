using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Videos4You.Startup))]
namespace Videos4You
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
