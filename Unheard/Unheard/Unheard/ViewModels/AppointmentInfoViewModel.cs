using Appointments.Model;
using Appointments.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Appointments.ViewModels
{
    public class AppointmentInfoViewModel : ViewModelBase
    {
        public AppointmentInfoViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        private AppointmentsInfo _info;

        public AppointmentsInfo Info
        {
            get { return _info; }
            set { SetProperty(ref _info, value); }
        }

        private readonly IDatabase _database;
    }
    }

