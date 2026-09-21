using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Models
{
    public class Address
    {
        public required string City { get; set; }
        public required string Street { get; set; }
        public required string PostalCode { get; set; }

        public Address() { }

        [SetsRequiredMembers]
        public Address(string city, string street, string postalCode)
        {
            City = city;
            Street = street;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return $"{Street}, {PostalCode} {City}";
        }
    }
}
