using Newtonsoft.Json;
using Shared.Domain;
using System.Linq;
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
                var response = await client.GetAsync("http://localhost:5000/api/v1/content");
                response.EnsureSuccessStatusCode();
                var contentJson = await response.Content.ReadAsStringAsync();
                var photoSets = JsonConvert.DeserializeObject<PhotoSetsDataResult>(contentJson);
                System.Console.WriteLine($"{photoSets.ServerName}: {string.Join(", ", photoSets.PhotoSets.PhotoSet.Select(ps => ps.Id))}");
            }
        }
    }
}
