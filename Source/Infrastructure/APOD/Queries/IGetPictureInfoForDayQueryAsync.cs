using Core.Models;
using System;
using System.Threading.Tasks;

namespace Infrastructure.APOD.Queries
{
    public interface IGetPictureInfoForDayQueryAsync
    {
        Task<PictureInfo> ExecuteAsync(DateTime date);
    }
}
