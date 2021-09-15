using IsaLife.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IsaLife
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
            BindingContext = IOCProvider.GetInstance<EmployeeService>();
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    var httpClient = new HttpClient();
        //    var resultJson = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/users");
        //    var resultEmployee = JsonConvert.DeserializeObject<Employee[]>(resultJson);
        //    employees.ItemsSource = resultEmployee;
        //}
    }
}