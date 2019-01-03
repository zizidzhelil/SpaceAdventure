using Infrastructure.Providers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaceAdventure.Providers;

namespace SpaceAdventure.DependencyResolver
{
   public static class DependendencyResolver
   {
      public static ServiceCollection RegisterConcreteTypes(this ServiceCollection serviceCollection, IConfigurationRoot configuration)
      {
         serviceCollection.AddSingleton<IAppSettingsProvider>(new AppSettingsProvider(configuration));

         return serviceCollection;
      }
   }
}
