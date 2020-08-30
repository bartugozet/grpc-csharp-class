using Grpc.Core;
using Maximum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Maximum.FindMaximumService;

namespace server
{
    public class FindMaximumServiceImpl : FindMaximumServiceBase
    {
        public override async Task FindMaximum(IAsyncStreamReader<FindMaximumRequest> requestStream, IServerStreamWriter<FindMaximumResponse> responseStream, ServerCallContext context)
        {
            int result = 0;
            while (await requestStream.MoveNext())
            {
                Console.WriteLine("Receieved: " + requestStream.Current.Number);
                if (requestStream.Current.Number > result)
                {
                    result = requestStream.Current.Number;
                    await responseStream.WriteAsync(new FindMaximumResponse() { Result = result });
                }
            }
        }
    }
}
