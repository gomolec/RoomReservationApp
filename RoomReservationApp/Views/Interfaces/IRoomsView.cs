using RoomReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Views.Interfaces
{
    public interface IRoomsView
    {
        string RoomName { get; }
        int Capacity { get; }
        RoomType SelectedType { get; }
        Department SelectedDepartment { get; }

        void SetRoomsDataSource(List<Room> rooms);
        void SetDepartmentsList(List<Department> departments);
        void ShowMessage(string message);
    }
}
