using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ClientTester
{
    class Program
    {
        static async Task Main(string[] args)
        {            
            Console.WriteLine("MVC");
            await PerformRequest(100, ExecuteGetApiContentRequest);
            Console.WriteLine("GRPC");
            await PerformRequest(100, ExecuteGetContentV1Request);
        }

        static async Task ExecuteGetApiContentRequest(int id) => await WebClient.Program.GetApiContenAsync(id);

        static async Task ExecuteGetContentV1Request(int number) => await GrpcClient.Program.GetContent_v1Async(number);

        static async Task PerformRequest(int numberOfRequests, Func<int, Task> request)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < numberOfRequests; i++)
            {
                await request(i);
            }
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
        }
    }
}
