using AttendencyTracker.Domain;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
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

            logger.Information("Attendee #1 = {@Attendee}", someAttendee);
        }
    }
}
