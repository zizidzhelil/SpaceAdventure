using Infrastructure.Context;
using System.Net.Http;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class NasaContext : INasaContext
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public NasaContext(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> MakeStringRequest(string url)
        {
            var client = _httpClientFactory.CreateClient();
            var result = await client.GetStringAsync(url);
           
            return result;
        }

        public async Task<byte[]> MakeByteArrayRequest(string url)
        {
            var client = _httpClientFactory.CreateClient();
            var result = await client.GetByteArrayAsync(url);

            return result;
        }
    }
}
