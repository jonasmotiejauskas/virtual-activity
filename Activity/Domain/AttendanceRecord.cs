using System;

namespace AttendaceTracker.Domain
{
    public struct AttendanceRecord
    {
        public User Attendee { get; }
        public AttendanceStatus Status { get; }
        public string Comment { get; }

        public AttendanceRecord(
            User attendee,
            AttendanceStatus status = default, 
            string comment = default)
        {
            Attendee = attendee;
            Status = status;
            Comment = comment;
        }
    }
}
