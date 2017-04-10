using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TrainersMap.Startup))]

namespace TrainersMap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
