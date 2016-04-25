using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IoCSolid.Startup))]
namespace IoCSolid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
