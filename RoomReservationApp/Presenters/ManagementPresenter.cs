using RoomReservationApp.Models;
using RoomReservationApp.Repositories;
using RoomReservationApp.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Presenters
{
    public class ManagementPresenter
    {
        private readonly IManagementView view;
        private readonly DataRepository repository;

        public ManagementPresenter(IManagementView view, DataRepository repository)
        {
            this.view = view;
            this.repository = repository;

            UpdateLists();
        }

        public void AddTeacher()
        {
            if (string.IsNullOrWhiteSpace(view.TeacherFirstName) || string.IsNullOrWhiteSpace(view.TeacherLastName))
            {
                view.ShowMessage("Imię i nazwisko nie może być puste.");
                return;
            }

            var teacher = new Teacher(view.TeacherFirstName, view.TeacherLastName);
            repository.Teachers.Add(teacher);
            repository.SaveData();
            UpdateLists();
        }

        public void AddDepartment()
        {
            var address = new Address(view.City, view.Street, view.PostalCode);
            var dept = new Department(view.DepartmentName, address);

            repository.Departments.Add(dept);
            repository.SaveData();
            UpdateLists();
        }

        private void UpdateLists()
        {
            view.SetTeachersDataSource(repository.Teachers);
            view.SetDepartmentsDataSource(repository.Departments);
        }
    }
}
