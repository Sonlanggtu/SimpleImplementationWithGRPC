// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/payment.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PaymentService {
  public static partial class PaymentServicce
  {
    static readonly string __ServiceName = "Payment.PaymentServicce";

    static readonly grpc::Marshaller<global::PaymentService.MakePaymentRequest> __Marshaller_Payment_MakePaymentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PaymentService.MakePaymentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PaymentService.MakePaymentReply> __Marshaller_Payment_MakePaymentReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PaymentService.MakePaymentReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PaymentService.GetPaymentStatusRequest> __Marshaller_Payment_GetPaymentStatusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PaymentService.GetPaymentStatusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PaymentService.GetPaymentStatusResponse> __Marshaller_Payment_GetPaymentStatusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PaymentService.GetPaymentStatusResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::PaymentService.MakePaymentRequest, global::PaymentService.MakePaymentReply> __Method_MakePayment = new grpc::Method<global::PaymentService.MakePaymentRequest, global::PaymentService.MakePaymentReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MakePayment",
        __Marshaller_Payment_MakePaymentRequest,
        __Marshaller_Payment_MakePaymentReply);

    static readonly grpc::Method<global::PaymentService.GetPaymentStatusRequest, global::PaymentService.GetPaymentStatusResponse> __Method_GetPaymentStatus = new grpc::Method<global::PaymentService.GetPaymentStatusRequest, global::PaymentService.GetPaymentStatusResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetPaymentStatus",
        __Marshaller_Payment_GetPaymentStatusRequest,
        __Marshaller_Payment_GetPaymentStatusResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PaymentService.PaymentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for PaymentServicce</summary>
    public partial class PaymentServicceClient : grpc::ClientBase<PaymentServicceClient>
    {
      /// <summary>Creates a new client for PaymentServicce</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PaymentServicceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PaymentServicce that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PaymentServicceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PaymentServicceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PaymentServicceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::PaymentService.MakePaymentReply MakePayment(global::PaymentService.MakePaymentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MakePayment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PaymentService.MakePaymentReply MakePayment(global::PaymentService.MakePaymentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MakePayment, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PaymentService.MakePaymentReply> MakePaymentAsync(global::PaymentService.MakePaymentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MakePaymentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PaymentService.MakePaymentReply> MakePaymentAsync(global::PaymentService.MakePaymentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MakePayment, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::PaymentService.GetPaymentStatusResponse> GetPaymentStatus(global::PaymentService.GetPaymentStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPaymentStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::PaymentService.GetPaymentStatusResponse> GetPaymentStatus(global::PaymentService.GetPaymentStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetPaymentStatus, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PaymentServicceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PaymentServicceClient(configuration);
      }
    }

  }
}
#endregion
