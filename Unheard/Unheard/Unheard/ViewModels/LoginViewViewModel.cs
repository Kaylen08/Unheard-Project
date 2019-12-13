using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using Appointments.Messages.Security;
using Appointments.Model.Security;
using Appointments.Services.Interfaces;
using Appointments.ViewModels;

namespace Appointments.ViewModels
{
    public class LoginViewViewModel : ViewModelBase
    {
        private ISecurityService _securityService;
        private IEventAggregator _eventAggregator;

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        private DelegateCommand _signUpCommand;
        public DelegateCommand SignUpCommand =>
            _signUpCommand ?? (_signUpCommand = new DelegateCommand(ExecuteSignUpCommand));
        void ExecuteSignUpCommand()
        {
            NavigationService.NavigateAsync("SignUp");
        }


        public LoginViewViewModel(INavigationService navigation, ISecurityService securityService, IEventAggregator eventAggregator) : base(navigation)
        {
            _securityService = securityService;

            _eventAggregator = eventAggregator;
        }

        void ExecuteLoginCommand()
        {
            // DO YOUR OWN LOGIN LOGIC AND VALIDATION
            var loginResult = _securityService.LogIn("Test User", "Password");

            // I may have gotten a user profile somewhere..  Use whatever your app does
            var userProfile = new UserProfile();

            if (loginResult)
            {
                _eventAggregator.GetEvent<LoginMessage>().Publish(userProfile);
            }
        }

         
    }
}


 
