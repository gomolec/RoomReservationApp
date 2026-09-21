using RoomReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RoomReservationApp.Repositories
{
    public class SaveDataContainer
    {
        public List<Room> Rooms { get; set; } = [];
        public List<Department> Departments { get; set; } = [];
        public List<Teacher> Teachers { get; set; } = [];
        public List<Reservation> Reservations { get; set; } = [];
    }

    public class DataRepository
    {
        private readonly string filePath = "data.json";

        public List<Room> Rooms { get; set; } = [];
        public List<Department> Departments { get; set; } = [];
        public List<Teacher> Teachers { get; set; } = [];
        public List<Reservation> Reservations { get; set; } = [];

        public DataRepository()
        {
            LoadData();
        }

        public void SaveData()
        {
            var container = new SaveDataContainer
            {
                Rooms = this.Rooms,
                Departments = this.Departments,
                Teachers = this.Teachers,
                Reservations = this.Reservations
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(container, options);
            File.WriteAllText(filePath, json);
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var data = JsonSerializer.Deserialize<SaveDataContainer>(json);

                if (data != null)
                {
                    Rooms = data.Rooms ?? new List<Room>();
                    Departments = data.Departments ?? new List<Department>();
                    Teachers = data.Teachers ?? new List<Teacher>();
                    Reservations = data.Reservations ?? new List<Reservation>();
                }
            }
        }
    }
}
