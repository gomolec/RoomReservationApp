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
    public partial class RoomsControl : UserControl, IRoomsView
    {
        private RoomsPresenter presenter;

        public RoomsControl()
        {
            InitializeComponent();

            var roomTypeOptions = new[]
            {
                new { Name = "Komputerowa", Value = RoomType.Computer },
                new { Name = "Ćwiczeniowa", Value = RoomType.Exercise },
                new { Name = "Wykładowa", Value = RoomType.Lecture }
            };

            cmbRoomType.DataSource = roomTypeOptions;
            cmbRoomType.DisplayMember = "Name";
            cmbRoomType.ValueMember = "Value";
        }

        public void Initialize(DataRepository repository)
        {
            presenter = new RoomsPresenter(this, repository);
        }

        public string RoomName => txtRoomName.Text;
        public int Capacity => (int)numCapacity.Value;
        public RoomType SelectedType => (RoomType)cmbRoomType.SelectedValue;
        public Department SelectedDepartment => (Department)cmbDepartmentSelect.SelectedItem;

        public void SetRoomsDataSource(List<Room> rooms)
        {
            dgvRooms.DataSource = null;
            dgvRooms.DataSource = rooms;

            if (dgvRooms.Columns["Name"] != null) dgvRooms.Columns["Name"].HeaderText = "Nazwa / Numer";
            if (dgvRooms.Columns["Capacity"] != null) dgvRooms.Columns["Capacity"].HeaderText = "Pojemność";
            if (dgvRooms.Columns["Type"] != null) dgvRooms.Columns["Type"].HeaderText = "Typ sali";
            if (dgvRooms.Columns["Department"] != null) dgvRooms.Columns["Department"].HeaderText = "Wydział";
        }

        public void SetDepartmentsList(List<Department> departments)
        {
            cmbDepartmentSelect.DataSource = null;
            cmbDepartmentSelect.DataSource = departments;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            presenter.AddRoom();
            txtRoomName.Clear();
            numCapacity.Value = 1;
        }

        private void dgvRooms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRooms.Columns[e.ColumnIndex].Name == "Type" && e.Value is RoomType type)
            {
                switch (type)
                {
                    case RoomType.Computer: e.Value = "Komputerowa"; break;
                    case RoomType.Exercise: e.Value = "Ćwiczeniowa"; break;
                    case RoomType.Lecture: e.Value = "Wykładowa"; break;
                }
                e.FormattingApplied = true;
            }
        }

        public void RefreshData()
        {
            presenter?.UpdateLists();
        }

    }
}
