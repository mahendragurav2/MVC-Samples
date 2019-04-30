using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exception_Handling.Startup))]
namespace Exception_Handling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
