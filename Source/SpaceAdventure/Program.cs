using BL.DependencyResolver;
using ConsoleTableExt;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaceAdventure.Converters;
using SpaceAdventure.DependencyResolver;
using System;
using SpaceAdventure.Reports;
using System.Data;
using CommandLine;
using SpaceAdventure.Options;

namespace SpaceAdventure
{
    public class Program
    {
        private static DataTable asteroidsInfoDataTable;

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

            Parser.Default.ParseArguments<CliOptions>(args)
                .WithParsed<CliOptions>(o =>
                {
                    if (o.Functionality == "Asteroid info")
                    {
                        var asteroidsInfoService = serviceProvider.GetService<IAsteroidsInfoService>();
                        var result = asteroidsInfoService.GetAsteroidsInfoAsync(o.StartDate, o.EndDate).GetAwaiter().GetResult();

                        var converter = serviceProvider.GetService<IAsteroidsInfoDataTableConverter>();
                        asteroidsInfoDataTable = converter.ConvertAsteroidsToDataTable(result);

                        ConsoleTableBuilder
                           .From(asteroidsInfoDataTable)
                           .WithFormat(ConsoleTableBuilderFormat.Default)
                           .ExportAndWriteLine();

                        var writer = serviceProvider.GetService<IReportGenerator>();
                        writer.Generate(asteroidsInfoDataTable, DateTime.Today, o.Path);
                    }
                    else if (o.Functionality == "Picture info")
                    {
                        var pictureOfTheDayService = serviceProvider.GetService<IPictureService>();
                        var pictureInfoResult = pictureOfTheDayService.GetPictureForDayAsync(o.Date).GetAwaiter().GetResult();

                        var pictureInfoConverter = serviceProvider.GetService<IDataTableConverter>();
                        var pictureForDayDataTable = pictureInfoConverter.ConvertPictureForDayToDataTable(pictureInfoResult);

                        ConsoleTableBuilder
                           .From(pictureForDayDataTable)
                           .WithFormat(ConsoleTableBuilderFormat.Default)
                           .ExportAndWriteLine();

                        var pictureInfoWriter = serviceProvider.GetService<IReportGenerator>();
                        pictureInfoWriter.Generate(pictureForDayDataTable, o.Date, o.Path);
                    }           
                });    
        }
    }
}