using Core.Models;
using Infrastructure.APOD.Queries;
using Infrastructure.Context;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace DAL.APOD.Queries
{
    public class GetPictureForDayQueryAsync : IGetPictureForDayQueryAsync
    {
        private readonly INasaContext _nasaContext;

        public GetPictureForDayQueryAsync(INasaContext nasaContext)
        {
            _nasaContext = nasaContext;
        }

        public async Task<PictureInfo> ExecuteAsync(DateTime date)
        {
            string result = await _nasaContext.MakeRequest("");

            var pictureForDay = JsonConvert.DeserializeObject<PictureInfo>(result);

            return pictureForDay;
        }
    }
}
