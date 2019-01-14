using Infrastructure.Providers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaceAdventure.Converters;
using SpaceAdventure.Converters.Implementation;
using SpaceAdventure.Providers;
using SpaceAdventure.Reports;
using SpaceAdventure.Reports.Implementation;
using SpaceAdventure.Writers;
using SpaceAdventure.Writers.Implementation;
using System.IO.Abstractions;

namespace SpaceAdventure.DependencyResolver
{
    public static class DependendencyResolver
    {
        public static ServiceCollection RegisterConcreteTypes(this ServiceCollection serviceCollection, IConfigurationRoot configuration)
        {
            serviceCollection.AddSingleton<IAppSettingsProvider>(new AppSettingsProvider(configuration));

            serviceCollection.AddScoped<IDataTableConverter, DataTableConverter>();

            serviceCollection.AddScoped<IReportGenerator, ReportGenerator>();

            serviceCollection.AddScoped<ITextFileWriter, TextFileWriter>();

            serviceCollection.AddScoped<IFileSystem, FileSystem>();

            return serviceCollection;
        }
    }
}
