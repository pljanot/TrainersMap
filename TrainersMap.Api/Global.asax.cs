using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;

namespace TrainersMap.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ContainerConfiguration();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public void ContainerConfiguration()
        {
            
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterControllers(typeof(WebApiApplication).Assembly);

            // Register model binders that require DI.
            containerBuilder.RegisterModelBinders(typeof(WebApiApplication).Assembly);
            containerBuilder.RegisterModelBinderProvider();
            
            // Register web abstractions like HttpContextBase.
            containerBuilder.RegisterModule<AutofacWebTypesModule>();

            // Enable property injection in view pages.
            containerBuilder.RegisterSource(new ViewRegistrationSource());
            containerBuilder.RegisterFilterProvider();
            
            ApplicationDependenciesConfig.RegisterDependencies(containerBuilder);

            var config = GlobalConfiguration.Configuration;
            containerBuilder.RegisterApiControllers(typeof(WebApiApplication).Assembly);
            containerBuilder.RegisterWebApiFilterProvider(config);

            var container = containerBuilder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
