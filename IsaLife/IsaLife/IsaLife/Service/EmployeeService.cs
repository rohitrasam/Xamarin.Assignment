using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IsaLife.Service
{
    public class EmployeeService : IEmployeeService
    {
        public HttpClient _httpClient = new HttpClient();
        public List<Employee> Employees { get; set; }

        public async Task<List<Employee>> GetEmployees()
        {
            var resultJson = await _httpClient.GetStringAsync("https://reqres.in/api/users?page=2");
            List<Employee> resultEmployee = JsonConvert.DeserializeObject<List<Employee>>(resultJson);
            Employees = resultEmployee;
            return Employees;
        }

        public Task<List<Employee>> GetEmployeesId()
        {
            throw new NotImplementedException();
        }
    }
}
