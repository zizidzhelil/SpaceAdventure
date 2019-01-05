using Core.Models;
using DAL.Factories.ConcreteUrlBuilders;
using Infrastructure.APOD.Queries;
using Infrastructure.Context;
using Infrastructure.UrlFactory;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace DAL.APOD.Queries
{
    public class GetPictureInfoForDayQueryAsync : IGetPictureInfoForDayQueryAsync
    {
        private readonly INasaContext _nasaContext;
        private readonly IUrlFactory _urlFactory;

        public GetPictureInfoForDayQueryAsync(INasaContext nasaContext, IUrlFactory urlFactory)
        {
            _nasaContext = nasaContext;
            _urlFactory = urlFactory;
        }

        public async Task<PictureInfo> ExecuteAsync(DateTime date)
        {
            string result = await _nasaContext.MakeStringRequest(
                _urlFactory.Create(nameof(PictureInfoForDayUrlBuilder),
                date.ToString("yyyy-MM-dd")));

            PictureInfo pictureInfoForDay = JsonConvert.DeserializeObject<PictureInfo>(result);

            return pictureInfoForDay;
        }
    }
}
