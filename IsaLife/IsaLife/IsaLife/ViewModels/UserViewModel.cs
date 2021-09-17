
using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using IsaLife.Service;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IsaLife.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        
        private readonly IEmployeeService _employeeService;
        public ICommand AddUserCommand { get; set; }
        private List<Employee> users;
        public List<Employee> Users 
        { 
            get 
            {
                return users;
            }
            set
            {
                users = value;
                OnPropertyChanged(nameof(Users));
            }
        }
        public UserViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            Task.Run(async () =>
            {
                await GetEmployees();
            });

        }

        public async Task GetEmployees()
        {
            var result = await _employeeService.GetEmployees();
            Users = result.EmployeeList;
            OnPropertyChanged(nameof(Users));
        }
        
    }
}
