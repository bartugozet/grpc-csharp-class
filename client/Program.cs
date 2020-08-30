using Average;
using Dummy;
using Greet;
using Grpc.Core;
using Maximum;
using Prime;
using Sum;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace client
{
    class Program
    {
        const string target = "127.0.0.1:50051";
        //Stream API client için async Task'a çevrildi.
        static async Task Main(string[] args)
        {
            Channel channel = new Channel(target, ChannelCredentials.Insecure);

            //Stream API client için async'e çevrildi.
            await channel.ConnectAsync().ContinueWith((task) =>
            {
                if (task.Status == TaskStatus.RanToCompletion)
                    Console.WriteLine("The client connected successfully");
            });

            //var client = new DummyService.DummyServiceClient(channel);

            //DoSimpleSum(channel);
            //await CalculatePrime(channel);
            //await CalculateAverage(channel);
            await CalculateMaximum(channel);

            #region Greet
            //var client = new GreetingService.GreetingServiceClient(channel);
            //DoSimpleGreet(client);
            //await DoManyGreetings(client);
            //await DoLongGreet(client);
            //await DoGreetEveryone(client);
            #endregion Greet


            channel.ShutdownAsync().Wait();
            Console.ReadKey();
        }

        //Unary Sum
        public static void DoSimpleSum(Channel channel)
        {
            var client = new SumService.SumServiceClient(channel);
            var sum = new Sum.Sum()
            {
                FirstNumber = "3",
                LastNumber = "10"
            };
            var request = new SumRequest() { Sum = sum };
            var response = client.SumNumbers(request);
            Console.WriteLine(response.Result);
        }
       
        //Server Streaming Prime
        public static async Task CalculatePrime(Channel channel)
        {
            var client = new PrimeNumberService.PrimeNumberServiceClient(channel);
            var request = new PrimeNumberDecompositionRequest()
            {
                Number = 120
            };
            var response = client.PrimeNumberDecomposition(request);
            while (await response.ResponseStream.MoveNext())
            {
                Console.WriteLine(response.ResponseStream.Current.PrimeFactor);
                //One by one görmek için
                await Task.Delay(200);
            }
        }

        //Client Streaming Average
        public static async Task CalculateAverage(Channel channel)
        {
            var client = new ComputeAverageService.ComputeAverageServiceClient(channel);
            var stream = client.ComputeAverage();
            foreach (int i in Enumerable.Range(1, 4))
            {
                var request = new ComputeAverageRequest() { Number = i };
                await stream.RequestStream.WriteAsync(request);
            }
            await stream.RequestStream.CompleteAsync();
            var response = await stream.ResponseAsync;
            Console.WriteLine(response.Result);
        }

        //Bidi Streaming Maximum
        public static async Task CalculateMaximum(Channel channel)
        {
            var client = new FindMaximumService.FindMaximumServiceClient(channel);
            var stream = client.FindMaximum();

            var responseReaderTask = Task.Run(async () =>
            {
                while (await stream.ResponseStream.MoveNext())
                {
                    Console.WriteLine("Recieved: " + stream.ResponseStream.Current.Result);
                }
            });

            int[] list = { 1, 5, 3, 6, 2, 20 };

            foreach (var number in list)
            {
                Console.WriteLine("Sending: " + number);
                await stream.RequestStream.WriteAsync(new FindMaximumRequest()
                {
                    Number = number
                });
            }

            await stream.RequestStream.CompleteAsync();
            await responseReaderTask;
        }

        //Unary Greet
        public static void DoSimpleGreet(GreetingService.GreetingServiceClient client)
        {
            var greeting = new Greeting()
            {
                FirstName = "Bartu",
                LastName = "Gozet"
            };
            var request = new GreetingRequest() { Greeting = greeting };
            var response = client.Greet(request);
            Console.WriteLine(response.Result);
        }
        
        //Client Stream Greet
        public static async Task DoLongGreet(GreetingService.GreetingServiceClient client)
        {
            var greeting = new Greeting()
            {
                FirstName = "Bartu",
                LastName = "Gozet"
            };
            var request = new LongGreetRequest() { Greeting = greeting };
            var stream = client.LongGreet();

            foreach (var item in Enumerable.Range(1, 10))
            {
                await stream.RequestStream.WriteAsync(request);
            }
            await stream.RequestStream.CompleteAsync();
            var response = await stream.ResponseAsync;
            Console.WriteLine(response.Result);
        }
        
        //Server Stream Greet
        public static async Task DoManyGreetings(GreetingService.GreetingServiceClient client)
        {
            var greeting = new Greeting()
            {
                FirstName = "Bartu",
                LastName = "Gozet"
            };
            var request = new GreetManyTimesRequest() { Greeting = greeting };
            var response = client.GreetManyTimes(request);
            while (await response.ResponseStream.MoveNext())
            {
                Console.WriteLine(response.ResponseStream.Current.Result);
                //One by one görmek için
                await Task.Delay(200);
            }
        }
        
        //Bidi Stream Greet
        public static async Task DoGreetEveryone(GreetingService.GreetingServiceClient client)
        {
            var stream = client.GreetEveryone();

            var responseReaderTask = Task.Run(async () =>
            {
                while (await stream.ResponseStream.MoveNext())
                {
                    Console.WriteLine("Recieved: " + stream.ResponseStream.Current.Result);
                }
            });

            Greeting[] greetings =
            {
                new Greeting() {FirstName = "Bartu", LastName = "Gozet"},
                new Greeting() {FirstName = "Bartu2", LastName = "Gozet2"},
                new Greeting() {FirstName = "Bartu3", LastName = "Gozet3"},
            };

            foreach (var greeting in greetings)
            {
                Console.WriteLine("Sending: " + greeting.ToString());
                await stream.RequestStream.WriteAsync(new GreetEveryoneRequest()
                {
                    Greeting = greeting
                });
            }

            await stream.RequestStream.CompleteAsync();
            await responseReaderTask;
        }

    }
}
