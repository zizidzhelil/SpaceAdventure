using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public interface INasaContext
    {
        Task<string> MakeRequest(string url);
    }
}
