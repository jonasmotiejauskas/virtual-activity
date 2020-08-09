using AttendencyTracker.Domain;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using System;
using System.Threading.Tasks;

namespace AttendencyTracker
{
    class Program
    {
        static async Task Main()
        {
            var someAttendee = new Attendee("Jonas", "Motiejauskas");
            var logger = new LoggerConfiguration()
                .WriteTo.Console(theme: AnsiConsoleTheme.Code)
                .CreateLogger();

            while (true)
            {
                logger.Information("Attendee #1 = {@Attendee}", someAttendee);
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}
