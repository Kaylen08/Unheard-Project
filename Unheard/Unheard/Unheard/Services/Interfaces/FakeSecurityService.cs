using Prism.Events;
using Appointments.Enums;
using Appointments.Messages.Security;
using Appointments.Model.Security;
using Appointments.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Appointments.Services
{
    public class FakeSecurityService : ISecurityService
    {
        private IEventAggregator _eventAggregator;
        public IList<MenuItem> _allMenuItems;

        public bool LoggedIn { get; set; }

        public FakeSecurityService(IEventAggregator eventAggregator)
        {
            CreateMenuItems();

            _eventAggregator = eventAggregator;
        }

        public IList<MenuItem> GetAllowedAccessItems()
        {
            if (LoggedIn)
            {
                var accessItems = new List<MenuItem>();

                foreach (var item in _allMenuItems)
                {
                    if (item.MenuType == MenuTypeEnum.Secured || item.MenuType == MenuTypeEnum.UnSecured || item.MenuType == MenuTypeEnum.LogOut)
                    {
                        accessItems.Add(item);
                    }
                }

                return accessItems.OrderBy(x => x.MenuOrder).ToList();
            }
            else
            {
                var accessItems = new List<MenuItem>();

                foreach (var item in _allMenuItems)
                {
                    if (item.MenuType == MenuTypeEnum.UnSecured || item.MenuType == MenuTypeEnum.Login)
                    {
                        accessItems.Add(item);
                    }
                }

                return accessItems.OrderBy(x => x.MenuOrder).ToList();
            }
        }

        public bool LogIn(string userName, string password)
        {
            // Do Your Stuff to Check if Legit (ie API Calls)

            LoggedIn = true;

            return true;
        }

        public void LogOut()
        {
            LoggedIn = false;

            _eventAggregator.GetEvent<LogOutMessage>().Publish();
        }
        private void CreateMenuItems()
        {
            _allMenuItems = new List<MenuItem>();

            var menuItem = new MenuItem();
            menuItem.MenuItemId = 1;
            menuItem.MenuItemName = "Login";
            menuItem.NavigationPath = "NavigationPage/LoginPage";
            menuItem.MenuType = MenuTypeEnum.Login;
            menuItem.MenuOrder = 1;
            menuItem.ImageName = "login.png";

            _allMenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.MenuItemId = 2;
            menuItem.MenuItemName = "LogOut";
            menuItem.NavigationPath = "";
            menuItem.MenuOrder = 99;
            menuItem.MenuType = MenuTypeEnum.LogOut;
            menuItem.ImageName = "logout.png";

            _allMenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.MenuItemId = 3;
            menuItem.MenuItemName = "Home";
            menuItem.NavigationPath = "NavigationPage/HomePage";
            menuItem.MenuOrder = 3;
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.ImageName = "home.png";

            _allMenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.MenuItemId = 4;
            menuItem.MenuItemName = "About";
            menuItem.NavigationPath = "NavigationPage/AboutPage";
            menuItem.MenuOrder = 4;
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.ImageName = "about.png";

            _allMenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.MenuItemId = 4;
            menuItem.MenuItemName = "Set Appointment";
            menuItem.NavigationPath = "NavigationPage/SetAppointmentPage";
            menuItem.MenuOrder = 4;
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.ImageName = "Set.jpg";

            _allMenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.MenuItemId = 4;
            menuItem.MenuItemName = "Chat With Professional";
            menuItem.NavigationPath = "NavigationPage/ChatWithProfessionalPage";
            menuItem.MenuOrder = 4;
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.ImageName = "chat.png";

            _allMenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.MenuItemId = 4;
            menuItem.MenuItemName = "Start Diary";
            menuItem.NavigationPath = "NavigationPage/StartDiaryPage";
            menuItem.MenuOrder = 4;
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.ImageName = "diary.png";

            _allMenuItems.Add(menuItem);

        }
    }
}
