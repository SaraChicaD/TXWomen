using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TXWomen.Startup))]
namespace TXWomen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
