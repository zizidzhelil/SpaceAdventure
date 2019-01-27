using Common.Constants;
using Infrastructure.Providers;
using Infrastructure.UrlFactory.UrlBuilder;

namespace DAL.Factories.ConcreteUrlBuilders
{
    public class GetAsteroidsInfoUrlBuilder : IUrlBuilder
    {
        private readonly IAppSettingsProvider _appSettingsProvider;

        public GetAsteroidsInfoUrlBuilder(IAppSettingsProvider appSettingsProvider)
        {
            _appSettingsProvider = appSettingsProvider;
        }

        public string Build(params string[] args)
        {
            return $"{CommonConstants.BaseAsteroidsInfoUrl}?start_date={args[0]}&end_date={args[1]}&api_key={_appSettingsProvider.ApiKey}";
        }
    }
}