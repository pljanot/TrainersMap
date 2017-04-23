using Microsoft.Owin;
using Owin;
using TrainersMap.Api;

[assembly: OwinStartup(typeof(Startup))]

namespace TrainersMap.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
