using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Models
{
    public class Reservation
    {
        public required Room Room { get; set; }
        public required Teacher Teacher { get; set; }
        public required DateTime StartTime { get; set; }
        public required DateTime EndTime { get; set; }

        public Reservation() { }

        [SetsRequiredMembers]
        public Reservation(Room room, Teacher teacher, DateTime startTime, DateTime endTime)
        {
            Room = room;
            Teacher = teacher;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
