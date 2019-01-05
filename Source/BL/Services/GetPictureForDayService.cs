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
        private readonly IGetPictureInfoForDayQueryAsync _getPictureInfoForDayQueryAsync;
        private readonly IGetPictureForDayQueryAsync _getPictureForDayQueryAsync;

        public GetPictureForDayService(
            IGetPictureInfoForDayQueryAsync getPictureInfoForDayQueryAsync, 
            IGetPictureForDayQueryAsync getPictureForDayQueryAsync)
        {
            _getPictureInfoForDayQueryAsync = getPictureInfoForDayQueryAsync;
            _getPictureForDayQueryAsync = getPictureForDayQueryAsync;
        }

        public async Task<PictureForDayModel> GetPictureForDayAsync(DateTime date)
        {
            PictureInfo pictureInfo = await _getPictureInfoForDayQueryAsync.ExecuteAsync(date);
            byte[] pictureForDay = await _getPictureForDayQueryAsync.ExecuteAsync(pictureInfo.HDUrl);

            PictureForDayModel model = new PictureForDayModel(pictureInfo, pictureForDay);

            return model;
        }
    }
}
