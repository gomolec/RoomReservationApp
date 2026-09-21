using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Models
{
    public class Room
    {
        public required string Name { get; set; }
        public required int Capacity { get; set; }
        public required RoomType Type { get; set; }
        public required Department Department { get; set; }

        public Room() { }

        [SetsRequiredMembers]
        public Room(string name, int capacity, RoomType type, Department department)
        {
            Name = name;
            Capacity = capacity;
            Type = type;
            Department = department;
        }

        public override string ToString() => Name;
    }
}
