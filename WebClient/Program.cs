using Newtonsoft.Json;
using Shared.Domain;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebClient
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            await GetApiContenAsync();
        }

        public static async Task GetApiContenAsync(int id = 0)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"http://localhost:5000/api/v1/content/{id}");
                response.EnsureSuccessStatusCode();
                var contentJson = await response.Content.ReadAsStringAsync();
                var photoSets = JsonConvert.DeserializeObject<PhotoSetsDataResult>(contentJson);
                Console.WriteLine($"{photoSets.ActionName} - {photoSets.PhotoSets.PhotoSet[0].Id}");
            }
        }
    }
}
