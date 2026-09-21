using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Models
{
    public class Department
    {
        public required string Name { get; set; }
        public required Address Address { get; set; }

        public Department() { }

        [SetsRequiredMembers]
        public Department(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString() => Name;
    }
}
