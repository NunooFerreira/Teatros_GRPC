using System;
using Grpc.Net.Client;
using GrpcClient;
using System.Threading.Tasks;
using Sistema_de_reserva_bilhetes;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            String user = "Bessa";
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var reply = client.SayHello(new HelloRequest { Name = user });
            Console.WriteLine("Greeting: " + reply.Message);

            var secondReply = client.SayHelloAgain(new HelloRequest { Name = user });
            Console.WriteLine("Greeting: " + secondReply.Message);



            Console.ReadLine();

        }
    }
}
