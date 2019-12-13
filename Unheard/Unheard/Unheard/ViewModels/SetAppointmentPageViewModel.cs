using Appointments.Model;
using Appointments.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Appointments.ViewModels
{
    public class SetAppointmentPageViewModel : ViewModelBase
    {

        private AppointmentsInfo _info;

        public AppointmentsInfo Info
        {
            get { return _info; }
            set { SetProperty(ref _info, value); }
        }

        private readonly IDatabase _database;
   
private DelegateCommand _saveCommand;
        public DelegateCommand SaveCommand =>
            _saveCommand ?? (_saveCommand = new DelegateCommand(ExecuteSaveCommand));
        void ExecuteSaveCommand()
        {
            NavigationService.NavigateAsync("AppointmentInfo");
        }

        async void ExecuteSetAppointmentPage()
        {
            var Info = new AppointmentsInfo();
            await _database.SaveItemAsync(Info);

        }

        public SetAppointmentPageViewModel(INavigationService navigation, IDatabase database)
                : base(navigation)
        {
            Info = new AppointmentsInfo();
            _database = database;
        }
    }
}