using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GSKietSchool.Startup))]
namespace GSKietSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
