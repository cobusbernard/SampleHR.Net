using System;
using System.Threading;
using StructureMap;

namespace SampleHR.Net.DependencyResolver
{
    public static class ContainerBuilder
    {
        private static readonly Lazy<Container> _containerBuilder =
            new Lazy<Container>(DefaultContainer, LazyThreadSafetyMode.ExecutionAndPublication);

        public static IContainer Build()
        {
            return _containerBuilder.Value;
        }

        private static Container DefaultContainer()
        {
            return new Container(x =>
            {
                x.For<ISettingsRepository>().Use<SettingsRepository>();
            });
        }
    }
}
