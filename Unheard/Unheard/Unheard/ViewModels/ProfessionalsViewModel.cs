using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Appointments.ViewModels
{
    public class ProfessionalsViewModel : ViewModelBase
    {
        public ProfessionalsViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
        private DelegateCommand _saveCommand;
        public DelegateCommand SaveCommand =>
            _saveCommand ?? (_saveCommand = new DelegateCommand(ExecuteSaveCommand));
        void ExecuteSaveCommand()
        {
            NavigationService.NavigateAsync("SetAppointment");
        }

    }
}