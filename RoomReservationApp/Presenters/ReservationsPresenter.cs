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
    public class ReservationsPresenter
    {
        private readonly IReservationsView view;
        private readonly DataRepository repository;

        public ReservationsPresenter(IReservationsView view, DataRepository repository)
        {
            this.view = view;
            this.repository = repository;
            UpdateLists();
        }

        public void AddReservation()
        {
            if (view.SelectedRoom == null || view.SelectedTeacher == null)
            {
                view.ShowMessage("Wybierz salę i prowadzącego.");
                return;
            }

            if (view.StartTime >= view.EndTime)
            {
                view.ShowMessage("Czas zakończenia musi być późniejszy niż rozpoczęcia.");
                return;
            }

            if (HasConflict(view.SelectedRoom, view.StartTime, view.EndTime))
            {
                view.ShowMessage("Konflikt! Ta sala jest już zarezerwowana w tym terminie.");
                return;
            }

            var reservation = new Reservation(view.SelectedRoom, view.SelectedTeacher, view.StartTime, view.EndTime);
            repository.Reservations.Add(reservation);
            repository.SaveData();
            UpdateLists();
        }

        private bool HasConflict(Room room, DateTime start, DateTime end)
        {
            return repository.Reservations.Any(r =>
                r.Room.Name == room.Name &&
                start < r.EndTime &&
                end > r.StartTime);
        }

        public void UpdateLists()
        {
            view.SetReservationsDataSource(repository.Reservations.ToList());
            view.SetRoomsList(repository.Rooms.ToList());
            view.SetTeachersList(repository.Teachers.ToList());
        }
    }
}
