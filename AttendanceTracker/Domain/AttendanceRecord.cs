using System;

namespace AttendencyTracker.Domain
{
    public class AttendanceRecord
    {
        public Guid Attendee { get; }
        public AttendanceStatus Status { get; }
        public string Comment { get; }

        public AttendanceRecord(
            Guid attendee,
            AttendanceStatus status = default, 
            string comment = default)
        {
            Attendee = attendee;
            Status = status;
            Comment = comment;
        }
    }
}
