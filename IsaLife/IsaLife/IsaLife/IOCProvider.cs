using IsaLife.Service;
using IsaLife.ViewModels;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace IsaLife
{
    public static class IOCProvider
    {
        private static Container container = new Container();

        public static T GetInstance<T>() where T : class
        {
           return container.GetInstance<T>();
        }

        public static void Register()
        {
            container.Options.EnableAutoVerification = false;
            container.Register<LoginViewModel>();
            container.Register<UserViewModel>();
            container.Register<EmployeeService>();
        }
    }
}
