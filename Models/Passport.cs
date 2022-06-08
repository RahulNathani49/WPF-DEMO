using System;
using System.Collections.Generic;

namespace PassportWPF.Models
{
    public class Passport
    {
        private static int nextId = 101;

        public int Id { get; }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    lastName = value;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    country = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public int Age
        {
            get
            {
                TimeSpan timeSpan = DateTime.UtcNow - DateOfBirth;
                return (int)timeSpan.TotalDays / 365;
            }
        }

        public TravelLocation CurrentLocation
        {
            get
            {
                int index = travelHistory.Count - 1;
                return travelHistory[index];
            }
        }

        public bool Traveling
        {
            get
            {
                return CurrentLocation.Country != Country;
            }
        }

        private readonly List<TravelLocation> travelHistory;
        private string firstName;
        private string lastName;
        private string country;

        public Passport(string firstName, string lastName, DateTime dateOfBirth, string country)
        {
            ValidateStringParameter(firstName, nameof(firstName));
            ValidateStringParameter(lastName, nameof(lastName));
            ValidateStringParameter(country, nameof(country));

            Id = nextId++;
            this.firstName = firstName;
            this.lastName = lastName;
            DateOfBirth = dateOfBirth;
            this.country = country;

            travelHistory = new List<TravelLocation>();
            travelHistory.Add(new TravelLocation(Country, DateTime.UtcNow));
        }

        private static void ValidateStringParameter(string parameter, string parameterName)
        {
            if (parameter == null)
                throw new ArgumentNullException(parameterName);
            if (string.IsNullOrWhiteSpace(parameter))
                throw new ArgumentException($"Passport {parameterName} must not be empty or whitespace.");
        }

        public void Travel(string country)
        {
            if (CurrentLocation.Country != country)
                travelHistory.Add(new TravelLocation(country, DateTime.UtcNow));
        }

        public override string ToString()
        {
            return $"Passport {Id} {FullName}";
        }
    }
}
