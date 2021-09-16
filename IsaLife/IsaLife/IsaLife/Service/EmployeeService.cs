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

        public async Task<List<Employee>> GetEmployees()
        {
            var resultJson = await _httpClient.GetStringAsync("https://reqres.in/api/users?page=2");
            return JsonConvert.DeserializeObject<List<Employee>>(resultJson);
        }

        public Task<Employee> GetEmployeesId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
