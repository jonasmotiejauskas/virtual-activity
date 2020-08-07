using System;
using System.Collections.Generic;

namespace AttendencyTracker.Domain
{
    public class AttendanceSheet
    {
        private readonly Dictionary<Guid, AttendanceRecord> _internalSheet;

        public DateTime CalendarDate { get; }
        public IReadOnlyDictionary<Guid, AttendanceRecord> Attendancy { get => _internalSheet; }

        public AttendanceSheet(DateTime calendarDate, ICollection<Attendee> attendeees)
        {
            if (calendarDate.Kind != DateTimeKind.Utc)
                throw new ArgumentException(nameof(calendarDate));

            CalendarDate = calendarDate.Date;
            _ = attendeees ?? throw new ArgumentNullException(nameof(attendeees));

            _internalSheet = new Dictionary<Guid, AttendanceRecord>();
        }
    }
}
