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

        public async Task<Root> GetEmployees()
        {
            var resultJson = await _httpClient.GetStringAsync("https://reqres.in/api/users?page=2");
            return JsonConvert.DeserializeObject<Root>(resultJson);
        }

        public Task<Employee> GetEmployeesId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
