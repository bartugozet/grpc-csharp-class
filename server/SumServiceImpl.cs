using Greet;
using Grpc.Core;
using Sum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sum.SumService;

namespace server
{
    public class SumServiceImpl : SumServiceBase
    {
        public override Task<SumResponse> SumNumbers(SumRequest request, ServerCallContext context)
        {
            int sumresult = Int32.Parse(request.Sum.FirstNumber) + Int32.Parse(request.Sum.LastNumber);
            string result = String.Format("Sum of {0} {1} = {2}", request.Sum.FirstNumber, request.Sum.LastNumber, sumresult);
            return Task.FromResult(new SumResponse() { Result = result });

        }
    }
}
