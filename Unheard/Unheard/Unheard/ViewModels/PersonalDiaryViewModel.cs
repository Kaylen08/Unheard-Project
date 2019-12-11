using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Unheard.ViewModels
{
    public class PersonalDiaryViewModel : ViewModelBase
    {
        public PersonalDiaryViewModel(INavigationService navigationService ) :base(navigationService)
        {

        }
    }
}
