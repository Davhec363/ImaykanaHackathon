using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(imaykana.Startup))]
namespace imaykana
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
