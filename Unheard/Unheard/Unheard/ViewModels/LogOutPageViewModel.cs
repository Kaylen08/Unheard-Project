using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Unheard.ViewModels
{
    public class LogOutPageViewModel : ViewModelBase
    {
        public LogOutPageViewModel(INavigationService navigationService) :base(navigationService)
        {

        }
    }
}
