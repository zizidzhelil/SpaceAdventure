using Core.Models;
using System;
using System.Threading.Tasks;

namespace Infrastructure.APOD.Queries
{
    public interface IGetPictureForDayQueryAsync
    {
        Task<PictureInfo> ExecuteAsync(DateTime date);
    }
}
