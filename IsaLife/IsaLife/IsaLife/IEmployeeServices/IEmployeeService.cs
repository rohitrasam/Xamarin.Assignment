using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IsaLife
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task<List<Employee>> GetEmployeesId();
    }
}
