using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            // _employeeRepository = new MockupEmployeeRepository();
        }


        public IActionResult Index()
        {
            return View(_employeeRepository.GetEmployees());
        }

        public IActionResult Details(int id)
        {
            return View(_employeeRepository.GetEmployee(id));
        }
    }
}
