using IsaLife.ViewModels;
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
        public LoginUI()
        {
            InitializeComponent();
            BindingContext = IOCProvider.GetInstance<LoginViewModel>();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}