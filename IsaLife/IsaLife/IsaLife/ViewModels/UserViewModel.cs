
using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using SimpleInjector;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IsaLife.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        //public ICommand ShowEmployeeCommand { get; set; }

        private IEmployeeService _employeeService;

        private List<Employee> employees;
        public List<Employee> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                employees = value;
                OnPropertyChanged(nameof(Employees));
            }
        }
        public UserViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            Task.Run(async () =>
            {
                await GetEmployee();
            });
            //ShowEmployeeCommand = new Command(ShowEmployee);
        }

        //public void SeviceInjection(IEmployeeService employeeService)
        //{
        //    _employeeService = employeeService;
        //}

        public async Task GetEmployee()
        {

            var result = await _employeeService.GetEmployees();
            Employees = result.EmployeeList;
            OnPropertyChanged(nameof(Employees));
        }

    }
}
