using Sant01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sant01.Repository
{
    public interface IEmployeeRepository
    {
        Employee GetById(int id);
        IEnumerable<Employee> GetEmployees();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}
