using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace IsaLife
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployeesId(int id);
    }
}
