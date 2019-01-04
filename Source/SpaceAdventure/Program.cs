using BL.DependencyResolver;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaceAdventure.DependencyResolver;
using System;

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

            var pictureOfTheDayService = serviceProvider.GetService<IGetPictureForDayService>();
            var result = pictureOfTheDayService.GetPictureForDayAsync(DateTime.Today).GetAwaiter().GetResult();
        }
   }
}
