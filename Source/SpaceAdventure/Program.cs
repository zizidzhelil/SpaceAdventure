using BL.DependencyResolver;
using ConsoleTableExt;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaceAdventure.Converters;
using SpaceAdventure.DependencyResolver;
using System;
using SpaceAdventure.Reports;

namespace SpaceAdventure
{
    public class Program
    {
        public static void Main(string[] args)
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
            var result = pictureOfTheDayService.GetPictureForDayAsync(DateTime.Today.AddDays(-1)).GetAwaiter().GetResult();

            var converter = serviceProvider.GetService<IDataTableConverter>();
            var pictureForDayDataTable = converter.ConvertPictureForDayToDataTable(result);

            Console.WriteLine($"Picture info for {result.Date}:");
            ConsoleTableBuilder
               .From(pictureForDayDataTable)
               .WithFormat(ConsoleTableBuilderFormat.Default)
               .ExportAndWriteLine();

            string folderPath = $"C:\\Users\\zizi\\Desktop\\SpaceAdventure";

            var writer = serviceProvider.GetService<IReportGenerator>();
            writer.Generate(pictureForDayDataTable, result, DateTime.Today.AddDays(-1), folderPath);
        }
    }
}
