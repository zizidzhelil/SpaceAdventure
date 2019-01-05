using System.Threading.Tasks;

namespace Infrastructure.APOD.Queries
{
    public interface IGetPictureForDayQueryAsync
    {
        Task<byte[]> ExecuteAsync(string hdUrl);
    }
}
