using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult Index()
        {
            return View(_employeeRepository.GetEmployees());
        }

        // GET: Active employees
        public ActionResult Active()
        {
            return View(_employeeService.GetActiveEmployees());
        }

        // GET: Inactive employees
        public ActionResult Inactive()
        {
            return View(_employeeService.GetInactiveEmployees());
        }

        // GET: Employee/id
        [HttpGet]
        public ActionResult Details(int id)
        {

            var employee = _employeeRepository.GetById(id);

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
        public ActionResult Create([Bind("Id,Name,Surename,DOB,Address,PersonIdentificationCode,Status")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Add(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employee = _employeeRepository.GetById(id);

            if(employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Name,Surename,DOB, PersonIdentificationCode, Address, Status")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                    _employeeRepository.Update(employee);

                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var employee = _employeeRepository.GetById(id);
            if(employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/DeleteConfirmed/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _employeeRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}