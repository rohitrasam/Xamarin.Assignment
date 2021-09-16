using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using IsaLife.ViewModels;
using System.Threading.Tasks;

namespace IsaLife.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public ICommand ShowEmployeeCommand { get; set; }

        private readonly IEmployeeService _employeeService;

        private Task<List<Employee>> employees;
        public Task<List<Employee>> Employees 
        { 
            get 
            {
                return employees;
            } 
            set {
                employees = value; 
                OnPropertyChanged(nameof(Employees));
            } 
        }

        public UserViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public void ShowEmployee()
        {
            Employees =_employeeService.GetEmployees();

        }

    }
}
