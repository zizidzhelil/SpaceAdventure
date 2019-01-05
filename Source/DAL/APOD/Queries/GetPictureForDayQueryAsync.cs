using Infrastructure.APOD.Queries;
using Infrastructure.Context;
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

        public async Task<byte[]> ExecuteAsync(string hdUrl)
        {
            byte[] result = await _nasaContext.MakeByteArrayRequest(hdUrl);

            return result;
        }
    }
}
