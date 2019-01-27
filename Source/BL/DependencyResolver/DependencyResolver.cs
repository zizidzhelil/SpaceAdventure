using BL.Grouper;
using BL.Services;
using DAL.APOD.Queries;
using DAL.Context;
using DAL.Factories;
using DAL.Factories.ConcreteUrlBuilders;
using Infrastructure.APOD.Queries;
using Infrastructure.Context;
using Infrastructure.Grouper;
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
            serviceCollection.AddScoped<IPictureService, PictureService>();
            serviceCollection.AddScoped<IAsteroidsInfoService, AsteroidsInfoService>();

            serviceCollection.AddScoped<IGetPictureInfoForDayQueryAsync, GetPictureInfoForDayQueryAsync>();
            serviceCollection.AddScoped<IGetPictureForDayQueryAsync, GetPictureForDayQueryAsync>();
            serviceCollection.AddScoped<IGetAsteroidsInfoQueryAsync, GetAsteroidsInfoQueryAsync>();

            serviceCollection.AddScoped<INasaContext, NasaContext>();

            serviceCollection.AddScoped<IUrlFactory>((serviceProvider) =>
            new UrlFactory(new Dictionary<string, Func<IUrlBuilder>>()
            {
               { nameof(PictureInfoForDayUrlBuilder), () => new PictureInfoForDayUrlBuilder(serviceProvider.GetService<IAppSettingsProvider>()) },
               { nameof(GetAsteroidsInfoUrlBuilder), () => new GetAsteroidsInfoUrlBuilder(serviceProvider.GetService<IAppSettingsProvider>()) }             
            }));

            serviceCollection.AddScoped<IGroupAsteroidsByDay, GroupAsteroidsByDay>();

            serviceCollection.AddHttpClient();

            return serviceCollection;
        }
    }
}