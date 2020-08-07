using AttendencyTracker.Domain;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace AttendencyTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var someAttendee = new Attendee("Jonas", "Motiejauskas");
            var logger = new LoggerConfiguration()
                .WriteTo.Console(theme: AnsiConsoleTheme.Code)
                .CreateLogger();

            logger.Debug("Attendee #1 = {@Attendee}", someAttendee);
        }
    }
}
