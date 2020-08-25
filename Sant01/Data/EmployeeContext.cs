using Microsoft.EntityFrameworkCore;
using Sant01.Data.DataConfiguration;
using Sant01.Data.Enum;
using Sant01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sant01.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            var employeeBuilder = modelbuilder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(modelbuilder);

            // INITIAL SEED FOR EMPLOYEE MODEL

            var employees = new Dictionary<int, Employee>
            {
                {1, new Employee{Id = 1, Name = "Jonas", Surename = "Jonaitis", Address = "Tilto g. 2-2", DOB = DateTime.Today, PersonIdentificationCode= 30101010001, Status = EmployeeStatus.Active}},
                {2, new Employee{Id = 2, Name = "Petras", Surename = "Petraitis", Address = "Milto g. 2-2", DOB = DateTime.Today, PersonIdentificationCode= 30202020002, Status = EmployeeStatus.Active}},
                {3, new Employee{Id = 3, Name = "Kazys", Surename = "Kazaitis", Address = "Bilto g. 2-2", DOB = DateTime.Today, PersonIdentificationCode= 30303030003, Status = EmployeeStatus.Active}},
                {4, new Employee{Id = 4, Name = "Tomas", Surename = "Tomaitis", Address = "Silto g. 2-2", DOB = DateTime.Today, PersonIdentificationCode= 30404040004, Status = EmployeeStatus.Inactive}},
                {5, new Employee{Id = 5, Name = "Arturas", Surename = "Arturaitis", Address = "Rilto g. 2-2", DOB = DateTime.Today, PersonIdentificationCode= 30505050005, Status = EmployeeStatus.Inactive}}
            };

            employeeBuilder.Entity<Employee>().HasData(employees.Select(x => x.Value).ToArray());
        }
    }
}