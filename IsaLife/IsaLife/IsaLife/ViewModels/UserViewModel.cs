using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using IsaLife.Service;
using System.Threading.Tasks;

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
            set {
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
            result.EmployeeList[0].Gender = "F";
            result.EmployeeList[1].Gender = "F";
            Users = result.EmployeeList;
            OnPropertyChanged(nameof(Users));
        }
        
    }
}
