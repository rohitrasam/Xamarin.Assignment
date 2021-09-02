using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IsaLife
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void RegisterTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(loginEmail.Text=="admin" && loginPassword.Text == "1234")
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Invalid Credentials", "Email or Password is incorrect!", "Ok");
            }
        }
    }
}