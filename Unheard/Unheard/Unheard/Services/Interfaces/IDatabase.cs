using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Appointments.Model.Security;
using Appointments.Model;

namespace Appointments.Services.Interfaces
{
    public interface IDatabase
    {
        Task<int> SaveItemAsync(UserProfile item);

    }
}
