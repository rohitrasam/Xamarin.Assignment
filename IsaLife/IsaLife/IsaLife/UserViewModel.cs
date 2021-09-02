using System;
using System.Collections.Generic;
using System.Text;

namespace IsaLife
{
    public class UserViewModel
    {
        public List<User> Users { get; set; }

        public UserViewModel()
        {
            Users = new List<User>();
            Users.Add(new User("Rohit Rasam", "Associate Consultant"));
            Users.Add(new User("Tanishq Thakral", "Associate Consultant"));
            Users.Add(new User("Saimanideep Chava", "Associate Consultant"));

        }
    }
}
