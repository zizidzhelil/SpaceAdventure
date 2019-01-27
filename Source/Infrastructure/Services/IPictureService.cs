using Infrastructure.Models;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IPictureService
    {
        Task<PictureForDayModel> GetPictureForDayAsync(DateTime date);
    }
}
