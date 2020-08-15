using AttendaceTracker.WebService.Protos;
using Grpc.Net.Client;
using System;

namespace TestClient
{
    class Program
    {
        static void Main()
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            using var channel = GrpcChannel.ForAddress("http://localhost:51333");

            var client = new AttendeeService.AttendeeServiceClient(channel);
            var reply = client.RegisterAttendee(new RegisterAttendeeRequest { Name = "Charlie", LastName = "Chaplin" });
            Console.WriteLine("Created new attendee: {Name: " + reply.Name + ", LastName: " + reply.LastName + ", Id: " + reply.Id + "}");
        }
    }
}
