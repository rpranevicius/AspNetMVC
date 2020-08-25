using Sant01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sant01.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetActiveEmployees();
        IEnumerable<Employee> GetInactiveEmployees();
    }
}
