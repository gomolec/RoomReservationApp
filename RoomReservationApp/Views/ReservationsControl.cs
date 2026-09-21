using RoomReservationApp.Models;
using RoomReservationApp.Presenters;
using RoomReservationApp.Repositories;
using RoomReservationApp.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomReservationApp
{
    public partial class ReservationsControl : UserControl, IReservationsView
    {
        private ReservationsPresenter presenter;

        public ReservationsControl()
        {
            InitializeComponent();
        }

        public void Initialize(DataRepository repository)
        {
            presenter = new ReservationsPresenter(this, repository);
        }

        public Room SelectedRoom => (Room)cmbRoomSelect.SelectedItem;
        public Teacher SelectedTeacher => (Teacher)cmbTeacherSelect.SelectedItem;
        public DateTime StartTime => dtpStart.Value;
        public DateTime EndTime => dtpEnd.Value;

        public void SetReservationsDataSource(List<Reservation> reservations)
        {
            dgvReservations.DataSource = null;
            dgvReservations.DataSource = reservations;

            if (dgvReservations.Columns["Room"] != null) dgvReservations.Columns["Room"].HeaderText = "Sala";
            if (dgvReservations.Columns["Teacher"] != null) dgvReservations.Columns["Teacher"].HeaderText = "Prowadzący";
            if (dgvReservations.Columns["StartTime"] != null) dgvReservations.Columns["StartTime"].HeaderText = "Czas od";
            if (dgvReservations.Columns["EndTime"] != null) dgvReservations.Columns["EndTime"].HeaderText = "Czas do";
        }

        public void SetRoomsList(List<Room> rooms)
        {
            cmbRoomSelect.DataSource = null;
            cmbRoomSelect.DataSource = rooms;
        }

        public void SetTeachersList(List<Teacher> teachers)
        {
            cmbTeacherSelect.DataSource = null;
            cmbTeacherSelect.DataSource = teachers;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            presenter.AddReservation();
        }

        public void RefreshData()
        {
            presenter?.UpdateLists();
        }
    }
}
