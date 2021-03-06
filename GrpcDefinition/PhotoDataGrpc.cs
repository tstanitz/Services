// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: PhotoData.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace GrpcDefinition {
  public static partial class ContentServer
  {
    static readonly string __ServiceName = "ContentServer";

    static readonly grpc::Marshaller<global::GrpcDefinition.Request> __Marshaller_Request = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcDefinition.Request.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcDefinition.PhotoSetsDataResult> __Marshaller_PhotoSetsDataResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcDefinition.PhotoSetsDataResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcDefinition.SendImage> __Marshaller_SendImage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcDefinition.SendImage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcDefinition.Response> __Marshaller_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcDefinition.Response.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcDefinition.Request, global::GrpcDefinition.PhotoSetsDataResult> __Method_GetContent = new grpc::Method<global::GrpcDefinition.Request, global::GrpcDefinition.PhotoSetsDataResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetContent",
        __Marshaller_Request,
        __Marshaller_PhotoSetsDataResult);

    static readonly grpc::Method<global::GrpcDefinition.SendImage, global::GrpcDefinition.Response> __Method_UploadImage = new grpc::Method<global::GrpcDefinition.SendImage, global::GrpcDefinition.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UploadImage",
        __Marshaller_SendImage,
        __Marshaller_Response);

    static readonly grpc::Method<global::GrpcDefinition.SendImage, global::GrpcDefinition.Response> __Method_UploadImageStream = new grpc::Method<global::GrpcDefinition.SendImage, global::GrpcDefinition.Response>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "UploadImageStream",
        __Marshaller_SendImage,
        __Marshaller_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcDefinition.PhotoDataReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ContentServer</summary>
    public abstract partial class ContentServerBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcDefinition.PhotoSetsDataResult> GetContent(global::GrpcDefinition.Request request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcDefinition.Response> UploadImage(global::GrpcDefinition.SendImage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcDefinition.Response> UploadImageStream(grpc::IAsyncStreamReader<global::GrpcDefinition.SendImage> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ContentServer</summary>
    public partial class ContentServerClient : grpc::ClientBase<ContentServerClient>
    {
      /// <summary>Creates a new client for ContentServer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ContentServerClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ContentServer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ContentServerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ContentServerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ContentServerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcDefinition.PhotoSetsDataResult GetContent(global::GrpcDefinition.Request request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetContent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcDefinition.PhotoSetsDataResult GetContent(global::GrpcDefinition.Request request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetContent, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcDefinition.PhotoSetsDataResult> GetContentAsync(global::GrpcDefinition.Request request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetContentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcDefinition.PhotoSetsDataResult> GetContentAsync(global::GrpcDefinition.Request request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetContent, null, options, request);
      }
      public virtual global::GrpcDefinition.Response UploadImage(global::GrpcDefinition.SendImage request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UploadImage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcDefinition.Response UploadImage(global::GrpcDefinition.SendImage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UploadImage, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcDefinition.Response> UploadImageAsync(global::GrpcDefinition.SendImage request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UploadImageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcDefinition.Response> UploadImageAsync(global::GrpcDefinition.SendImage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UploadImage, null, options, request);
      }
      public virtual grpc::AsyncClientStreamingCall<global::GrpcDefinition.SendImage, global::GrpcDefinition.Response> UploadImageStream(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UploadImageStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::GrpcDefinition.SendImage, global::GrpcDefinition.Response> UploadImageStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_UploadImageStream, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ContentServerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ContentServerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ContentServerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetContent, serviceImpl.GetContent)
          .AddMethod(__Method_UploadImage, serviceImpl.UploadImage)
          .AddMethod(__Method_UploadImageStream, serviceImpl.UploadImageStream).Build();
    }

  }
}
#endregion
