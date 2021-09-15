using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IsaLife.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public List<Employee> Employees { get; set; }
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var resultJson = await _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            var resultEmployee = JsonConvert.DeserializeObject<List<Employee>>(resultJson);
            Employees = resultEmployee;
            return Employees;
        }

        public async Task<List<Employee>> GetEmployeesId()
        {

        }
    }
}
