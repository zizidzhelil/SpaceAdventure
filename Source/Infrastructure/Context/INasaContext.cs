using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public interface INasaContext
    {
        Task<string> MakeStringRequest(string url);

        Task<byte[]> MakeByteArrayRequest(string url);
    }
}
