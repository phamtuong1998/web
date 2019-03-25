using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tuong.Startup))]
namespace tuong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
