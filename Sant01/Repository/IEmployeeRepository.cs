using Sant01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sant01.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetById(int id);
        Task<IEnumerable<Employee>> GetEmployees();
        Task Add(Employee employee);
        Task Update(Employee employee);
        Task Delete(int id);
    }
}
