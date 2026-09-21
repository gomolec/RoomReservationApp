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
    public class RoomsPresenter
    {
        private readonly IRoomsView view;
        private readonly DataRepository repository;

        public RoomsPresenter(IRoomsView view, DataRepository repository)
        {
            this.view = view;
            this.repository = repository;

            UpdateLists();
        }

        public void AddRoom()
        {
            if (string.IsNullOrWhiteSpace(view.RoomName))
            {
                view.ShowMessage("Nazwa sali nie może być pusta.");
                return;
            }

            if (view.SelectedDepartment == null)
            {
                view.ShowMessage("Musisz wybrać wydział.");
                return;
            }

            var room = new Room(view.RoomName, view.Capacity, view.SelectedType, view.SelectedDepartment);
            repository.Rooms.Add(room);
            repository.SaveData();
            UpdateLists();
        }

        public void UpdateLists()
        {
            view.SetRoomsDataSource(repository.Rooms.ToList());
            view.SetDepartmentsList(repository.Departments.ToList());
        }
    }
}
