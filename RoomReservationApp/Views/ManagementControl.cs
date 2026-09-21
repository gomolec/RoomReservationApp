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
    public partial class ManagementControl : UserControl, IManagementView
    {
        private ManagementPresenter presenter;

        public ManagementControl()
        {
            InitializeComponent();
        }

        public void Initialize(DataRepository repository)
        {
            presenter = new ManagementPresenter(this, repository);
        }

        public string TeacherFirstName => txtTeacherFirstName.Text;
        public string TeacherLastName => txtTeacherLastName.Text;
        public string DepartmentName => txtDeptName.Text;
        public string City => txtDeptCity.Text;
        public string Street => txtDeptStreetAndNumber.Text;
        public string PostalCode => txtDeptZipCode.Text;

        public void SetTeachersDataSource(List<Teacher> teachers)
        {
            dgvTeachers.DataSource = null;
            dgvTeachers.DataSource = teachers;

            if (dgvTeachers.Columns["FirstName"] != null) dgvTeachers.Columns["FirstName"].HeaderText = "Imie";
            if (dgvTeachers.Columns["LastName"] != null) dgvTeachers.Columns["LastName"].HeaderText = "Nazwisko";
        }

        public void SetDepartmentsDataSource(List<Department> departments)
        {
            dgvDepartments.DataSource = null;
            dgvDepartments.DataSource = departments;

            if (dgvDepartments.Columns["Name"] != null) dgvDepartments.Columns["Name"].HeaderText = "Nazwa wydziału";
            if (dgvDepartments.Columns["Address"] != null) dgvDepartments.Columns["Address"].HeaderText = "Adres siedziby";
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            presenter.AddTeacher();
            txtTeacherFirstName.Clear();
            txtTeacherLastName.Clear();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            presenter.AddDepartment();
            txtDeptName.Clear();
            txtDeptCity.Clear();
            txtDeptStreetAndNumber.Clear();
            txtDeptZipCode.Clear();
        }

        public void RefreshData()
        {
            //presenter?.
        }
    }
}
