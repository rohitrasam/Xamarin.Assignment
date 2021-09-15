using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using IsaLife.ViewModels;

namespace IsaLife.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public ICommand AddUserCommand { get; set; }
        private ObservableCollection<Employee> employees;
        public ObservableCollection<Employee> Employees 
        { 
            get 
            {
                return employees;
            } 
            set {
                employees = value; 
                OnPropertyChanged(nameof(Employees));
            } 
        }

        public UserViewModel()
        {
            
            //Users = new ObservableCollection<User>();
            //Users.Add(new User("Rohit Rasam", "Associate Consultant", "https://s3.amazonaws.com/files.freshteam.com/production/8673/attachments/2002932042/medium/Rohit_Rasam.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIARX2EI6XT3P6LHG72%2F20210902%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20210902T160353Z&X-Amz-Expires=604800&X-Amz-Security-Token=IQoJb3JpZ2luX2VjEMv%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCXVzLWVhc3QtMSJHMEUCIHUqa0MoIH5C%2BAQh%2BQSZmlkaSzRtEVQRd70AI32tFF36AiEA94YGuT7T5Xu5ALD9dSLlVI4PdYdCPIZIQgxydhgw%2BVcq%2BgMIFBADGgwxMTk4NjU0MDY5NTEiDEL3In%2F%2Fo5o%2BCKXD8CrXA0e6elerw1zwaFKBUaC8PKuAYQ1kGS7W4tQf8K8sMQnSUQQFxuS3fGroGTzXsf5%2FUIoHxpyjSN02eCEUan84uQA3Y9ZU%2BtrLZbjdswuNeRs%2FjqVyYEpsyA7nHPmGAF6HAjcNZDahZpkg8YK45x%2FXEswNTCzwGtIf57fo4JJFY6KAfW0ySBFh0IAIiU81BKBEjWQBRgvpa%2FI6zXNT3GnDEcBY%2Fc2aPFFus3RHdma39eZJeG1%2B9I4aaK3NE9PbOtbI%2FbQhVo6BnL5ZeTA2HikDuEvLSveWRVWTbSk0PTVjXEJUTebGFz1JyLxCBJKxF4igFB%2FpaxgjAXb7zwex%2BwpDkVYjl2IWJ2A3vGZ%2BH1xM7Mx%2FhZ0XAg2TVNBiVDqeJ%2BSgE1MDiiFiykJtfpJl76Rhb8LN3fxRXxGPmBgz4GYyh6N24qniWcZgh8%2B6yXY9xYAMjxJ8sdRtUrFMzEvtJceIW2Cc87CayZ4Z%2B%2FAWZgs%2Bmtl%2Bm%2BMeLeZrh9ttf8tpmSLChAmSFNqm1RQs9mVlOyGbQic2aLjhcdguaww8bQA37fFzcln6Y8ojMUVtJzyJqg4ifG3IJD9EBXtm7L5mNY8kZPOK9oegg5Ue%2BpArlfAkLcq2%2BoX%2FmWaOIzDz2MKJBjqlAXuG%2FVbSCtqRA5Z8SMX5aHVdEkjv2LeolQh64jl4Y06APLh5NVLO1zjSSrZwUcDUag2Ve8cwshzxpzbqn4%2Fgde6ZGZNcT%2BlaaVyBB7BC4fJQu6JEBWCveSgp585%2FLp6Yfdv89OiDGyE%2FeFXbcfA5EUUyDr7brehuaPgrqTClmqG%2BvqWajQ%2B8THpSFvVyGpg4IRIABvISFxFnzYTAbv07rbiOEvhI0g%3D%3D&X-Amz-SignedHeaders=host&X-Amz-Signature=b8d8f17f108febc4461cd208924596867716ae9058854535962aff24ced35478"));
            //Users.Add(new User("Tanishq Thakral", "Associate Consultant", "https://instagram.flko7-1.fna.fbcdn.net/v/t51.2885-19/s320x320/99126784_596976664266789_1773859516593471488_n.jpg?_nc_ht=instagram.flko7-1.fna.fbcdn.net&_nc_ohc=rRjMA8rGjG8AX9tgm9v&edm=ABfd0MgBAAAA&ccb=7-4&oh=0986491764d799c639f7fcf541f4344c&oe=6137E071&_nc_sid=7bff83"));
            //Users.Add(new User("Saimanideep Chava", "Associate Consultant" , "https://s3.amazonaws.com/files.freshteam.com/production/8673/attachments/2002934360/medium/Saimanideep.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIARX2EI6XTZXFQECFL%2F20210902%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20210902T155634Z&X-Amz-Expires=604800&X-Amz-Security-Token=IQoJb3JpZ2luX2VjEMv%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCXVzLWVhc3QtMSJGMEQCIGFgQeh6R3judb1oAu5k3uOOFHCJJXyNW8NpXPzvNQY1AiBDgCToidxUBPgysit98%2BrFKkWtvhKa8MN06VLUylDYayr6AwgUEAMaDDExOTg2NTQwNjk1MSIMeJaqvpxB3uYu3FjQKtcD%2BRj15WBYsOwHlnRB3cbS8X%2BPrr%2F9aotS9sngpzyEwfYsYsR9FHbxv4EG%2F1KweYCn7ITt3LbpLQZ%2F6Y6z0OCiRfE6tRXVm9p6PV%2BVvB0IecA07offQqtVouWH0m8HUeGN4JZWgfhkxPJxtvNAZA8qxK4OfM8pJp1EwOZn%2FLjQxiYPYwfNXnfrrIf5HboUQl%2F%2FlKMH0HAZo%2Fjm6p1N997ZjAnwA3BPQkBYpeM7JYMzcXgEhOq%2BICmXJssPcIVpsJwWOdVY4ETzlDaOF1VL93mtobI0NFh2o0Q4aFpTdxYacBEei9zN9w720xb74m9y1j4DhZzpOSADoV8hJ9uWqhEzH4FNEQRwkqSWnKBFn7wU0BAkASL%2B1dyXE9ZI8f%2F54nL83IibV5NRUGd3fJCCa6Lr%2BFeCJ1tDVUOY7jo3f0BLH0uvbCvG5THEMFwYqu632%2BUSkGljO0vPCa3CsbMuS5uEz4eJ8XxH9flie96vJTQJkxY3mpd%2BjlYr4yA3MRBvA6Iacf7gNTfUofonUDhZEaMTs5F%2F81qbPqWCg6Wp5Ri9%2F4FrjC91kjYVLuuaz%2BYJcc5B32%2B0H69VdliRT%2F0OYdNZ48x4HybsnuOude%2BwDGKo3i%2Bw%2FPUNtzz3MMHXwokGOqYB8vvNNqcSAO104ZhxwngEZgMFa6umdOkVHh%2F4zMpuUZtHxOuhsDrP6WVqy6%2FEbYcumEbhD66%2BB5WIUUKyoTgyu8OXgITe6VHYVsLkiq3jSlfnkQdXubkPDgE%2FvEcIhmA%2FwzAJVpWGJyreoz1AQZGrPO8y3E0r5yka4eCpfZKlwR60EE1ohmFv5nMWrLThkILybv3%2BAgUqrJGxbJEW0tOGc65tiAWFmA%3D%3D&X-Amz-SignedHeaders=host&X-Amz-Signature=11b20ac2704e11e97cc0323fd6d273462c39a2532423249e9dd4de1e8c601c1b"));

            //AddUserCommand = new Command(AddUser);
        }

        private async void AddUser()
        {

            //Users.Add(new User("Saimani", "Associate Consultant", "https://s3.amazonaws.com/files.freshteam.com/production/8673/attachments/2002934360/medium/Saimanideep.jpg?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIARX2EI6XTZXFQECFL%2F20210902%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20210902T155634Z&X-Amz-Expires=604800&X-Amz-Security-Token=IQoJb3JpZ2luX2VjEMv%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCXVzLWVhc3QtMSJGMEQCIGFgQeh6R3judb1oAu5k3uOOFHCJJXyNW8NpXPzvNQY1AiBDgCToidxUBPgysit98%2BrFKkWtvhKa8MN06VLUylDYayr6AwgUEAMaDDExOTg2NTQwNjk1MSIMeJaqvpxB3uYu3FjQKtcD%2BRj15WBYsOwHlnRB3cbS8X%2BPrr%2F9aotS9sngpzyEwfYsYsR9FHbxv4EG%2F1KweYCn7ITt3LbpLQZ%2F6Y6z0OCiRfE6tRXVm9p6PV%2BVvB0IecA07offQqtVouWH0m8HUeGN4JZWgfhkxPJxtvNAZA8qxK4OfM8pJp1EwOZn%2FLjQxiYPYwfNXnfrrIf5HboUQl%2F%2FlKMH0HAZo%2Fjm6p1N997ZjAnwA3BPQkBYpeM7JYMzcXgEhOq%2BICmXJssPcIVpsJwWOdVY4ETzlDaOF1VL93mtobI0NFh2o0Q4aFpTdxYacBEei9zN9w720xb74m9y1j4DhZzpOSADoV8hJ9uWqhEzH4FNEQRwkqSWnKBFn7wU0BAkASL%2B1dyXE9ZI8f%2F54nL83IibV5NRUGd3fJCCa6Lr%2BFeCJ1tDVUOY7jo3f0BLH0uvbCvG5THEMFwYqu632%2BUSkGljO0vPCa3CsbMuS5uEz4eJ8XxH9flie96vJTQJkxY3mpd%2BjlYr4yA3MRBvA6Iacf7gNTfUofonUDhZEaMTs5F%2F81qbPqWCg6Wp5Ri9%2F4FrjC91kjYVLuuaz%2BYJcc5B32%2B0H69VdliRT%2F0OYdNZ48x4HybsnuOude%2BwDGKo3i%2Bw%2FPUNtzz3MMHXwokGOqYB8vvNNqcSAO104ZhxwngEZgMFa6umdOkVHh%2F4zMpuUZtHxOuhsDrP6WVqy6%2FEbYcumEbhD66%2BB5WIUUKyoTgyu8OXgITe6VHYVsLkiq3jSlfnkQdXubkPDgE%2FvEcIhmA%2FwzAJVpWGJyreoz1AQZGrPO8y3E0r5yka4eCpfZKlwR60EE1ohmFv5nMWrLThkILybv3%2BAgUqrJGxbJEW0tOGc65tiAWFmA%3D%3D&X-Amz-SignedHeaders=host&X-Amz-Signature=11b20ac2704e11e97cc0323fd6d273462c39a2532423249e9dd4de1e8c601c1b"));
            //OnPropertyChanged(nameof(Users));
        }
    }
}
