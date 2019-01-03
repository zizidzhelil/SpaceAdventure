using BL.DependencyResolver;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaceAdventure.DependencyResolver;

namespace SpaceAdventure
{
   class Program
   {
      static void Main(string[] args)
      {
         IConfigurationRoot configguration = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

         ServiceProvider serviceProvider = new ServiceCollection()
            .RegisterConcreteTypes(configguration)
            .RegisterTypes()
            .BuildServiceProvider();
      }
   }
}
