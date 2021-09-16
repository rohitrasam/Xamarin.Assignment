using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsaLife
{
    public class Employee
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; } = "M";
    }

    public class Root
    {
        public List<Employee> Employees { get; set; }
    }
}
