using Prism.Commands;
using Prism.Navigation;
using Unheard.Model.Security;
using Unheard.Services.Interfaces;

namespace Unheard.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        private UserProfile _user;

        public UserProfile User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }

        private readonly IDatabase _database;

        public INavigationService _navigation;
        private DelegateCommand _signup;
        public DelegateCommand ToSignUp =>
            _signup ?? (_signup = new DelegateCommand(ExecuteToSignUp));

        async void ExecuteToSignUp()
        { 
           var Users = new UserProfile();
           await _database.SaveItemAsync(User);
           await _navigation.NavigateAsync("LoginPage");
        }
        public SignUpViewModel(INavigationService navigation, IDatabase database) 
            :base(navigation)
        {
            User = new UserProfile();
            _database = database;
            _navigation = navigation;
        }
    }
}
