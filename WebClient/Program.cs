using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
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
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkClass>();
        }
    }

    public class BenchmarkClass
    {
        private readonly HttpClient client;

        public BenchmarkClass()
        {
            client = new HttpClient();
        }

        [Benchmark]
        public async Task Execute()
        {
            var response = await client.GetAsync($"http://localhost:5000/api/v1/content/{1}");
            response.EnsureSuccessStatusCode();
            var contentJson = await response.Content.ReadAsStringAsync();
            var photoSets = JsonConvert.DeserializeObject<PhotoSetsDataResult>(contentJson);
        }
    }
}
