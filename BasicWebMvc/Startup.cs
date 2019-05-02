using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicWebMvc.Startup))]
namespace BasicWebMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
