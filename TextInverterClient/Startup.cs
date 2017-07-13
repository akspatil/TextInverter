using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TextInverterClient.Startup))]
namespace TextInverterClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
