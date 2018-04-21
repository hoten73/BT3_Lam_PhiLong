using SmartHotel2.Mvvm.Commands;
using SmartHotel2.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SmartHotel2.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _userName;
        private string _password;
        //private string _passwordStrength;
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value, () => { LoginCommand.RaiseCanExecuteChanged(); });

        }

        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(Login, CanLogin).ObservesProperty(() => UserName)
                .ObservesProperty(() => Password);
        }

        private void Login()
        {
            //throw new NotImplementedException();
            NavigationService.NavigateToAsync<MainViewModel>();
        }

        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);

        }

        public DelegateCommand LoginCommand { get; }
        public void SetUserName(string value)
        {
            UserName = value;
        }


    }
}
