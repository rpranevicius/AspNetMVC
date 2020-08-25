using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sant01.Data.Enum;
using Sant01.Models;
using Sant01.Repository;
using Sant01.Service;

namespace Sant01.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeRepository employeeRepository, IEmployeeService employeeService)
        {
            _employeeRepository = employeeRepository;
            _employeeService = employeeService;
        }

        // GET: All employees
        public async Task<ActionResult> Index(string statusFilter)
        {
            ViewData["StatusFilter"] = statusFilter;

            var employees = await _employeeRepository.GetEmployees();

            if (!String.IsNullOrEmpty(statusFilter))
            {
                var byteValue = Convert.ToByte(statusFilter);
                employees = employees.Where(e => e.Status == (EmployeeStatus)byteValue);
            }

            return View( employees);
        }

        // GET: Employee/id
        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {

            var employee = await _employeeRepository.GetById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Id,Name,Surename,DOB,Address,PersonIdentificationCode,Status")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeRepository.Add(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            var employee = await _employeeRepository.GetById(id);

            if(employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind("Id,Name,Surename,DOB, PersonIdentificationCode, Address, Status")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                   await  _employeeRepository.Update(employee);

                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Delete/5
        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            var employee = await _employeeRepository.GetById(id);
            if(employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/DeleteConfirmed/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await _employeeRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}