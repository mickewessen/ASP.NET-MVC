using Repository.Interfaces;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Mockups
{
    public class MockupEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;

        public MockupEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee(1, "Micke", "Wessén", "IT"),
                new Employee(2, "Daniel", "Wessén", "IT"),
                new Employee(2, "Samuel", "Wessén", "IT")
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(employee => employee.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employees.OrderBy(e => e.Id).ToList();
        }
    }
}
