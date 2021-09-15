using IsaLife.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace IsaLife.ViewModels
{
    public class LoginViewModel: BaseViewModel
    {
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
                Application.Current.MainPage.Navigation.PushAsync(new UserPage());
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Invalid Credentials", "Email or Password is incorrect!", "Ok");
            }
        }

    }
}
