using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace IsaLife
{
    public class LoginViewModel: BaseViewModel
    {
        private readonly INavigation _navigation;
        public string Email { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
        }

        private void OnRegister()
        {
            Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }

        private void OnLogin()
        {
            if (Email == "admin" && Password == "1234")
            {
                Application.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
            else
            {
                //DisplayAlert("Invalid Credentials", "Email or Password is incorrect!", "Ok");
            }
        }

    }
}
