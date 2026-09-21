using RoomReservationApp.Repositories;

namespace RoomReservationApp
{
    public partial class Form1 : Form
    {
        private DataRepository repository;

        public Form1()
        {
            InitializeComponent();

            repository = new DataRepository();

            managementControl1.Initialize(repository);

            roomsControl1.Initialize(repository);

            reservationsControl1.Initialize(repository);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Sale")
            {
                roomsControl1.RefreshData();
            }

            managementControl1.RefreshData();
            roomsControl1.RefreshData();
            reservationsControl1.RefreshData();
        }
    }
}
