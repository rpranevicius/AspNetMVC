using Sant01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sant01.Service
{
    public interface IEmployeeService
    {
        Task <IEnumerable<Employee>> GetActiveEmployees();
        Task <IEnumerable<Employee>> GetInactiveEmployees();
    }
}
