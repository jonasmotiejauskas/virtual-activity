using AttendaceTracker.WebService.Protos;
using Grpc.Net.Client;
using System;
using System.Net.Http;

namespace TestClient
{
    class Program
    {
        static void Main()
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:32782");
            var client = new AttendeeService.AttendeeServiceClient(channel);
            var reply = client.RegisterAttendee(new RegisterAttendeeRequest { Name = "Charlie", LastName = "Chaplin" });
            Console.WriteLine("Created new attendee: {Name: " + reply.Name + ", LastName: " + reply.LastName + ", Id: " + reply.Id + "}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
