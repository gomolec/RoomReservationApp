using RoomReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Views.Interfaces
{
    public interface IManagementView
    {
        string TeacherFirstName { get; }
        string TeacherLastName { get; }
        string DepartmentName { get; }
        string City { get; }
        string Street { get; }
        string PostalCode { get; }

        void SetTeachersDataSource(List<Teacher> teachers);
        void SetDepartmentsDataSource(List<Department> departments);
        void ShowMessage(string message);
    }
}
