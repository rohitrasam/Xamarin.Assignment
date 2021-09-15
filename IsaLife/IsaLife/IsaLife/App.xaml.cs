using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FreshMvvm;
using FreshTinyIoC;
using Xamarin.Forms.Internals;
using SimpleInjector;

namespace IsaLife
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            IOCProvider.Register();

            MainPage = new NavigationPage(new LoginUI());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
