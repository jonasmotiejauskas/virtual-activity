using System;
using System.Collections.Generic;
using System.Linq;

namespace AttendaceTracker.Domain
{
    public class ActivityCalendar
    {
        private readonly List<DateTimeOffset> _activityDates;

        public ICollection<DateTimeOffset> CalendarDate { get => _activityDates; }

        public ActivityCalendar(IEnumerable<DateTimeOffset> calendar = default)
        {
            if (calendar is null)
                _activityDates = new List<DateTimeOffset>();

            _activityDates = calendar.ToList();
        }

        public void AddActivityDate(DateTimeOffset activityStartDateTime)
        {
            _activityDates.Add(activityStartDateTime);
        }
    }
}
