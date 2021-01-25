using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Employee
    {

        public Employee()
        {

        }

        public Employee(int id, string firstName, string lastName, string department)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
}
