using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsaLife
{
    public class Employee
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }

    public class Root
    {
        public List<Employee> data { get; set; }
    }
}
