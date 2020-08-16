using System.Threading.Tasks;
using AttendaceTracker.Domain;
using AttendaceTracker.WebService.Protos;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace AttendanceTracker.WebService.Services
{
    public class AttendeeService : AttendaceTracker.WebService.Protos.AttendeeService.AttendeeServiceBase
    {
        private readonly ILogger<AttendeeService> _logger;
        public AttendeeService(ILogger<AttendeeService> logger)
        {
            _logger = logger;
        }

        public override Task<RegisteredAttendee> RegisterAttendee(RegisterAttendeeRequest request, ServerCallContext context)
        {
            var attendeeEntity = new User(request.Name, request.LastName);

            _logger.LogInformation("Created Attendee: {attendee}", attendeeEntity);

            return Task.FromResult(new RegisteredAttendee
            {
                Name = attendeeEntity.Name,
                LastName = attendeeEntity.LastName,
                Id = attendeeEntity.Id.ToString()
            });
        }
    }
}
