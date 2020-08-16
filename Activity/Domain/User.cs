using System;

namespace AttendaceTracker.Domain
{
    public struct User
    {
        public Guid Id { get; }
        public string Name { get; }
        public string LastName { get; }

        public User(string id, string name, string lastName)
        {
            var isParsed = Guid.TryParse(id, out var parsedGuid);
            Id = !isParsed ? throw new ArgumentException("Failed to parse Guid", nameof(id)) : parsedGuid;
            Name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentNullException(nameof(name)) : name;
            LastName = string.IsNullOrWhiteSpace(lastName) ? throw new ArgumentNullException(nameof(name)) : lastName;
        }

        public User(string name, string lastName)
        {
            Name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentNullException(nameof(name)) : name;
            LastName = string.IsNullOrWhiteSpace(lastName) ? throw new ArgumentNullException(nameof(name)) : lastName;
            Id = Guid.NewGuid();
        }
    }
}
