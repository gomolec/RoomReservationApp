using RoomReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Views.Interfaces
{
    public interface IReservationsView
    {
        Room SelectedRoom { get; }
        Teacher SelectedTeacher { get; }
        DateTime StartTime { get; }
        DateTime EndTime { get; }

        void SetReservationsDataSource(List<Reservation> reservations);
        void SetRoomsList(List<Room> rooms);
        void SetTeachersList(List<Teacher> teachers);
        void ShowMessage(string message);
    }
}
