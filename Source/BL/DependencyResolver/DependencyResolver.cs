using BL.Services;
using DAL.APOD.Queries;
using DAL.Context;
using DAL.Factories;
using DAL.Factories.ConcreteUrlBuilders;
using Infrastructure.APOD.Queries;
using Infrastructure.Context;
using Infrastructure.Providers;
using Infrastructure.Services;
using Infrastructure.UrlFactory;
using Infrastructure.UrlFactory.UrlBuilder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace BL.DependencyResolver
{
    public static class DependencyResolver
    {
        public static ServiceCollection RegisterTypes(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IGetPictureForDayService, GetPictureForDayService>();

            serviceCollection.AddScoped<IGetPictureInfoForDayQueryAsync, GetPictureInfoForDayQueryAsync>();
            serviceCollection.AddScoped<IGetPictureForDayQueryAsync, GetPictureForDayQueryAsync>();

            serviceCollection.AddScoped<INasaContext, NasaContext>();

            serviceCollection.AddScoped<IUrlFactory>((serviceProvider) =>
            new UrlFactory(new Dictionary<string, Func<IUrlBuilder>>()
            {
               { nameof(PictureInfoForDayUrlBuilder), () => new PictureInfoForDayUrlBuilder(serviceProvider.GetService<IAppSettingsProvider>()) }
            }));

            serviceCollection.AddHttpClient();

            return serviceCollection;
        }
    }
}
