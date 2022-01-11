using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptsImplementation.SolidPrinciple.DependencyInversion
{
    /*The Dependency Inversion Principle (DIP) states that high-level modules/classes
     * should not depend on low-level modules/classes. Both should depend upon abstractions.
     * Secondly, abstractions should not depend upon details. Details should depend upon abstractions.*/

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
    public interface IEmployeeDataAccess
    {
            Employee GetEmployeeDetails(int id);
     }
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // In real time get the employee details from db
            //but here we are hardcoded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Test",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}
