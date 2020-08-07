using System;

namespace AttendencyTracker.Domain
{
    public class Attendee
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public Attendee(string id, string name, string lastName)
        {
            var isParsed = Guid.TryParse(id, out var parsedGuid);
            Id = !isParsed ? throw new ArgumentException("Failed to parse Guid", nameof(id)) : parsedGuid;
            Name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentNullException(nameof(name)) : name;
            LastName = string.IsNullOrWhiteSpace(lastName) ? throw new ArgumentNullException(nameof(name)) : lastName;
        }

        public Attendee(string name, string lastName)
        {
            Name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentNullException(nameof(name)) : name;
            LastName = string.IsNullOrWhiteSpace(lastName) ? throw new ArgumentNullException(nameof(name)) : lastName;
            Id = Guid.NewGuid();
        }
    }
}
