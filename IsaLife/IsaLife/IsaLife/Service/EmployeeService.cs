using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IsaLife.Service
{
    public class EmployeeService : IEmployeeService
    {
        HttpClient httpClient = new HttpClient();
        public async Task<Root> GetEmployees()
        {
            HttpResponseMessage response = await httpClient.GetAsync("https://reqres.in/api/users");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<Root>(result);
                return json;
            }
            return null;
        }
    }
}