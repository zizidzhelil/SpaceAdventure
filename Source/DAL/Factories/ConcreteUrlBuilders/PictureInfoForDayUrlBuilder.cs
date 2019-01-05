using Common.Constants;
using Infrastructure.Providers;
using Infrastructure.UrlFactory.UrlBuilder;

namespace DAL.Factories.ConcreteUrlBuilders
{
    public class PictureInfoForDayUrlBuilder : IUrlBuilder
    {
        private readonly IAppSettingsProvider _appSettingsProvider;

        public PictureInfoForDayUrlBuilder(IAppSettingsProvider appSettingsProvider)
        {
            _appSettingsProvider = appSettingsProvider;
        }

        public string Build(params string[] args)
        {           
            return $"{CommonConstants.BaseSpaceAdventureUrl}?date={args[0]}&hd=true&api_key={_appSettingsProvider.ApiKey}";
        }
    }
}
