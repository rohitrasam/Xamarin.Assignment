using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IsaLife
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {        
        private readonly
        
        public LoginUI()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        private void Button_Clicked()
        {
            if (loginEmail.Text == "admin" && loginPassword.Text == "1234")
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Invalid Credentials", "Email or Password is incorrect!", "Ok");
            }
        }
    }
}