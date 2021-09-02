using System;
using System.Collections.Generic;
using System.Text;

namespace IsaLife
{
    public class User
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        public User(string name, string designation)
        {
            Name = name;
            Designation = designation;
        }

    }
}
