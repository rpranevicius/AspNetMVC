using Microsoft.EntityFrameworkCore;
using Sant01.Data;
using Sant01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sant01.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _context = employeeContext;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = _context
                            .Employees
                            .FirstOrDefault(x => x.Id == id);
            _context.Remove(employee);
            _context.SaveChanges();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
