using AttendencyTracker.Domain;
using System;
using Serilog;

namespace AttendencyTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var someAttendee = new Attendee("Jonas", "Motiejauskas");
            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            logger.Information("Attendee #1 = {@Attendee}", someAttendee);
        }
    }
}
