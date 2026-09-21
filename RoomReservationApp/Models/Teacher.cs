using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Models
{
    public class Teacher
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public Teacher() { }

        [SetsRequiredMembers]
        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() => FirstName + " " + LastName;
    }
}
