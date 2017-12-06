using Newtonsoft.Json;
using Shared.Domain;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using(var client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:5000/api/content");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var photoSets = JsonConvert.DeserializeObject<PhotoSetsDataResult>(content);
            }
        }
    }
}
