using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Unheard.ViewModels
{
    public class SignUpViewModel : BindableBase
    {
        public INavigationService _navigation;
        private DelegateCommand _signup;
        public DelegateCommand ToSignUp =>
            _signup ?? (_signup = new DelegateCommand(ExecuteToSignUp));

        async void ExecuteToSignUp()
        {
            await _navigation.NavigateAsync("SignUpPage");
        }
        public SignUpViewModel(INavigationService navigation)
        {
            _navigation = navigation;
        }
    }
}
