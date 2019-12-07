using PrismAppExample.Model.Security;
using System;
using System.Collections.Generic;
using System.Text;
using Unheard.Model.Security;

namespace PrismAppExample.Services.Interfaces
{
    public interface ISecurityService
    {
        IList<MenuItem> GetAllowedAccessItems();
        bool LogIn(string userName, string password);
        void LogOut();
    }
}
