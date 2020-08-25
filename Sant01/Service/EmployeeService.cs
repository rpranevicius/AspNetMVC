using Sant01.Data.Enum;
using Sant01.Models;
using Sant01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sant01.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetActiveEmployees()
        {
            var employees = _employeeRepository.GetEmployees()
                                                .Where(x => x.Status == EmployeeStatus.Active).ToList() ;

            return employees;
        }


        public IEnumerable<Employee> GetInactiveEmployees()
        {
            var employees = _employeeRepository.GetEmployees()
                                                .Where(x => x.Status == EmployeeStatus.Inactive).ToList();

            return employees;
        }
    }
}
