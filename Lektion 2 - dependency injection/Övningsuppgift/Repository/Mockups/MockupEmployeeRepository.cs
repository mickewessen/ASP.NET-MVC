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
                new Employee(1,"Sofie","Lesnik","Human Resources"),
                new Employee(2,"Michael","Wessén","IT"),
                new Employee(3,"Samuel","Wessèn","IT"),
                new Employee(4,"Daniel","Wessén","Service Desk"),
                new Employee(5,"Annika","Lesnik","Recruiting"),
                new Employee(6,"Mattias","Lesnik","Sales"),
                new Employee(7,"Martin","Lesnik","Facility")
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(Employee => Employee.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employees.OrderBy(employees => employees.Id).ToList();
        }
    }
}
