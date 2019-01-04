using BL.Services;
using DAL.APOD.Queries;
using DAL.Context;
using Infrastructure.APOD.Queries;
using Infrastructure.Context;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BL.DependencyResolver
{
    public static class DependencyResolver
    {
        public static ServiceCollection RegisterTypes(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IGetPictureForDayService, GetPictureForDayService>();

            serviceCollection.AddScoped<IGetPictureForDayQueryAsync, GetPictureForDayQueryAsync>();

            serviceCollection.AddScoped<INasaContext, NasaContext>();

            serviceCollection.AddHttpClient();

            return serviceCollection;
        }
    }
}
