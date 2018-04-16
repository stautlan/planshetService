using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(planshetService.Startup))]

namespace planshetService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}