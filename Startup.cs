using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ds869415MIS4200940.Startup))]
namespace ds869415MIS4200940
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
