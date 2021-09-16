using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace IsaLife.Service
{
    public interface IEmployeeService
    {
        //Task<ObservableCollection<Root>> GetEmployees();
        Task<Root> GetEmployees();
    }
}
