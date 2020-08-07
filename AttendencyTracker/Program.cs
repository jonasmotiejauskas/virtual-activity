using AttendencyTracker.Domain;
using System;

namespace AttendencyTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var someAttendee = new Attendee("Jonas", "Motiejauskas");
            Console.WriteLine($"{someAttendee.Id.ToString()}");
        }
    }
}
