using System;
using System.Collections.Generic;
using System.Linq;

namespace AttendaceTracker.Domain
{
    public class AttendanceSheet
    {
        private readonly List<AttendanceRecord> _internalSheet;

        public DateTime CalendarDate { get; }
        public IReadOnlyList<AttendanceRecord> Attendancy { get => _internalSheet; }

        public AttendanceSheet(DateTime calendarDate, ICollection<Attendee> attendees)
        {
            if (calendarDate.Kind != DateTimeKind.Utc)
                throw new ArgumentException(nameof(calendarDate));

            CalendarDate = calendarDate.Date;
            _ = attendees ?? throw new ArgumentNullException(nameof(attendees));

            _internalSheet = new List<AttendanceRecord>(attendees.Select(x => new AttendanceRecord(x.Id)));
        }

        public AttendanceSheet(DateTime calendarDate, ICollection<AttendanceRecord> existingSheet)
        {
            if (calendarDate.Kind != DateTimeKind.Utc)
                throw new ArgumentException(nameof(calendarDate));

            CalendarDate = calendarDate.Date;
            _ = existingSheet ?? throw new ArgumentNullException(nameof(existingSheet));

            _internalSheet = existingSheet.ToList();
        }
    }
}
