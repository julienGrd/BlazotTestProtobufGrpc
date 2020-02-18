using BlazotTestProtobufGrpc.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazotTestProtobufGrpc.Server.Controllers
{
    public class MyCalculator : ICalculator
    {
        ValueTask<MultiplyResult> ICalculator.MultiplyAsync(MultiplyRequest request)
            => new ValueTask<MultiplyResult>(new MultiplyResult { Result = request.X * request.Y });
    }
}
