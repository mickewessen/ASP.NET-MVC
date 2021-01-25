using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Övningsuppgift.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            return View(_employeeRepository.GetEmployees());
        }

        public IActionResult Create()
        {
            return View(_employeeRepository.GetEmployees());
        }



        public IActionResult Details(int id)
        {
            return View(_employeeRepository.GetEmployee(id));
        }

        public IActionResult Edit(int id)
        {
            return View(_employeeRepository.GetEmployee(id));
        }

        public IActionResult Delete(int id)
        {
            return View(_employeeRepository.GetEmployee(id));
        }
    }
}
