using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unheard.Model.Security;

namespace Unheard.Services.Interfaces
{
    public interface IDatabase
    {
        Task<int> SaveItemAsync(UserProfile item);

    }
}
