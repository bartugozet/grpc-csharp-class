using Average;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Average.ComputeAverageService;

namespace server
{
    public class ComputeAverageServiceImpl : ComputeAverageServiceBase
    {
        public override async Task<ComputeAverageResponse> ComputeAverage(IAsyncStreamReader<ComputeAverageRequest> requestStream, ServerCallContext context)
        {

            double result;
            int count = 0, sum = 0;
            while (await requestStream.MoveNext())
            {
                sum += requestStream.Current.Number;
                count++;
            }
            result = (double)sum / count;
            return new ComputeAverageResponse() { Result = result };
        }
    }
}
