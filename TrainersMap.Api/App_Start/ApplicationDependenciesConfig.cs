using Autofac;

namespace TrainersMap.Api
{
    public static class ApplicationDependenciesConfig
    {
        public static void RegisterDependencies(ContainerBuilder containerBuilder)
        {
            // Register application dependencies.
            // containerBuilder.RegisterType<ViewDependency>().As<IViewDependency>();
            // containerBuilder.RegisterType<FilterDependency>().As<IFilterDependency>();
        }
    }
}