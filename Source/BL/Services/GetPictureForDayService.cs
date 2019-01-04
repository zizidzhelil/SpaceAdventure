using Core.Models;
using Infrastructure.APOD.Queries;
using Infrastructure.Models;
using Infrastructure.Services;
using System;
using System.Threading.Tasks;

namespace BL.Services
{
    public class GetPictureForDayService : IGetPictureForDayService
    {
        private readonly IGetPictureForDayQueryAsync _getPictureForDayQueryAsync;

        public GetPictureForDayService(IGetPictureForDayQueryAsync getPictureForDayQueryAsync)
        {
            _getPictureForDayQueryAsync = getPictureForDayQueryAsync;
        }

        public async Task<PictureForDayModel> GetPictureForDayAsync(DateTime date)
        {
            PictureInfo pictureOfTheDay = await _getPictureForDayQueryAsync.ExecuteAsync(DateTime.Today);
            PictureForDayModel model = new PictureForDayModel(pictureOfTheDay);

            return model;
        }
    }
}
