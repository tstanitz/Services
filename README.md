# Services

Compare the speed of a JSON REST api and GRPC server with sending a small message and wait for the response and to updload an image as a byte[]. The GRPC server are also tested to upload multiple image one-by-one or with client side streaming.

JSON results:
``` ini

BenchmarkDotNet=v0.10.11, OS=Windows 10 Redstone 2 [1703, Creators Update] (10.0.15063.726)
Processor=Intel Core i7-6700 CPU 3.40GHz (Skylake), ProcessorCount=8
Frequency=3328122 Hz, Resolution=300.4698 ns, Timer=TSC
.NET Core SDK=2.2.0-preview1-007582
  [Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT


```
|         Method |         Mean |       Error |       StdDev |
|--------------- |-------------:|------------:|-------------:|
| ExecuteContent |     879.7 us |    17.54 us |     44.96 us |
|  ExecuteUpload | 480,795.5 us | 9,580.19 us | 19,352.46 us |

GRPC results:
``` ini

BenchmarkDotNet=v0.10.11, OS=Windows 10 Redstone 2 [1703, Creators Update] (10.0.15063.726)
Processor=Intel Core i7-6700 CPU 3.40GHz (Skylake), ProcessorCount=8
Frequency=3328122 Hz, Resolution=300.4698 ns, Timer=TSC
.NET Core SDK=2.2.0-preview1-007582
  [Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT


```
|                        Method |        Mean |      Error |     StdDev |
|------------------------------ |------------:|-----------:|-----------:|
|             ExecuteGetContent |    238.1 us |   5.225 us |   5.132 us |
|                 ExecuteUpload |  7,333.2 us |  52.429 us |  49.042 us |
|           ExecuteUploadStream |  7,161.5 us |  66.389 us |  58.852 us |
|         ExecuteMultipleUpload | 16,250.4 us | 269.116 us | 238.565 us |
| ExecuteUploadMultipleInStream | 12,041.7 us | 239.370 us | 651.225 us |
