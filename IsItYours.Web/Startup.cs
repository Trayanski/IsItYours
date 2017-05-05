using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IsItYours.Web.Startup))]
namespace IsItYours.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
