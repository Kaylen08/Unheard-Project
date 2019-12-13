using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Appointments.Model;
using System.IO;
using System.Threading.Tasks;
using Appointments.Services.Interfaces;

namespace Appointments.Services
{
    class AppointmentsDatabase : IDatabase
    {

        private readonly SQLiteAsyncConnection database;
        public AppointmentsDatabase()
        {
            var dbPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Appointment.db3");
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<AppointmentsInfo>().Wait();
        }
        public Task<List<AppointmentsInfo>> GetItemsAsync()
        {
            return database.Table<AppointmentsInfo>().ToListAsync();
        }
        public Task<List<AppointmentsInfo>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<AppointmentsInfo>("SELECT * FROM [Info]");
        }
        public Task<AppointmentsInfo> GetItemAsync(int id)
        {
            return database.Table<AppointmentsInfo>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> InsertTShirtOrder(AppointmentsInfo info)
        {
            return database.InsertAsync(info);
        }
        public Task<int> UpdateTShirtOrder(AppointmentsInfo info)
        {
            return database.UpdateAsync(info);
        }
        public Task<int> SaveItemAsync(AppointmentsInfo item)
        {

            return database.InsertAsync(item);

        }
    }
}
