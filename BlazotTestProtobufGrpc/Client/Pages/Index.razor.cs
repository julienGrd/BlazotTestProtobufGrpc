using BlazotTestProtobufGrpc.Shared;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazotTestProtobufGrpc.Client.Pages
{
    public partial class Index
    {
        protected MultiplyResult Result  { get;set; }
        protected async Task Multiply()
        {
            GrpcClientFactory.AllowUnencryptedHttp2 = true;
            using (var channel = GrpcChannel.ForAddress("http://localhost:10042"))
            {
                var calculator = channel.CreateGrpcService<ICalculator>();
                this.Result = await calculator.MultiplyAsync(new MultiplyRequest { X = 12, Y = 4 });
                Console.WriteLine(this.Result);
            }
        }
    }
}
