using Infrastructure.Models;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IGetPictureForDayService
    {
        Task<PictureForDayModel> GetPictureForDayAsync(DateTime date);
    }
}
