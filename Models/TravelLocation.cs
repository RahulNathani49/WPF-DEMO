using System;

namespace PassportWPF.Models
{
    public class TravelLocation
    {
        public string Country { get; }
        public DateTime TimeOfEntry { get; }

        public TimeSpan TimeSinceEntry
        {
            get
            {
                return DateTime.UtcNow - TimeOfEntry;
            }
        }

        public TravelLocation(string country, DateTime timeOfEntry)
        {
            if (country == null)
                throw new ArgumentNullException(nameof(country));
            if (string.IsNullOrWhiteSpace(country))
                throw new ArgumentException("Country must not be empty or whitespace.", nameof(country));

            Country = country;
            TimeOfEntry = timeOfEntry;
        }

        public override string ToString()
        {
            return $"[{Country}, {TimeOfEntry}]";
        }
    }
}
