using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IsaLife
{
    public class Employee
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        
        [JsonIgnore]
        public string Gender { get; set; } = "M";
    }

    

    public class Root
    {
        [JsonProperty ("data")]
        public List<Employee> EmployeeList { get; set; }
        
    }
}
