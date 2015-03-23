using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_hotdog.Startup))]
namespace mvc_hotdog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
