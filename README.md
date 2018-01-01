# Services

Comparing the performance of the JSON REST api and the GRPC server with sending a small message and wait for the response and to updload an image as a byte[]. 
In the GRPC server the upload of multiple images one-by-one or with client side streaming are also measured.

JSON results:
``` ini

BenchmarkDotNet=v0.10.11, OS=Windows 10 Redstone 2 [1703, Creators Update] (10.0.15063.786)
Processor=Intel Core i7-7600U CPU 2.80GHz (Kaby Lake), ProcessorCount=4
Frequency=2835938 Hz, Resolution=352.6170 ns, Timer=TSC
.NET Core SDK=2.1.2
  [Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT


```
|         Method |         Mean |        Error |       StdDev |
|--------------- |-------------:|-------------:|-------------:|
| ExecuteContent |     991.6 us |     19.46 us |     25.30 us |
|  ExecuteUpload | 464,164.0 us | 10,965.25 us | 21,644.34 us |


GRPC results:
``` ini

BenchmarkDotNet=v0.10.11, OS=Windows 10 Redstone 2 [1703, Creators Update] (10.0.15063.786)
Processor=Intel Core i7-7600U CPU 2.80GHz (Kaby Lake), ProcessorCount=4
Frequency=2835938 Hz, Resolution=352.6170 ns, Timer=TSC
.NET Core SDK=2.1.2
  [Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT


```
|                        Method |        Mean |     Error |    StdDev |
|------------------------------ |------------:|----------:|----------:|
|             ExecuteGetContent |    328.1 us |  19.85 us |  30.31 us |
|                 ExecuteUpload |  5,157.1 us |  78.23 us |  73.18 us |
|           ExecuteUploadStream |  4,873.5 us |  44.28 us |  39.25 us |
|         ExecuteMultipleUpload | 14,227.0 us | 280.51 us | 374.47 us |
| ExecuteUploadMultipleInStream | 11,791.6 us | 231.31 us | 275.36 us |


##Execute the measurements

Start the server and the clients in a separate command window:

```
dotnet run -c Release
```

## Host the servers in docker

### Web server

In the WebApi folder execute the following commands

```
dotnet publish -c Release
docker build .\ -t webapi:0.1
docker run -d -p 5001:5001 webapi:0.1
```

### GRPC server

In the GrpcServer folder execute the following commands

```
dotnet publish -c Release
docker build .\ -t grpc:0.1
docker run -d -p 5002:5002 grpc:0.1
```

### Start the clients

In the clients folders execute the following command

```
dotnet run -c Release
```