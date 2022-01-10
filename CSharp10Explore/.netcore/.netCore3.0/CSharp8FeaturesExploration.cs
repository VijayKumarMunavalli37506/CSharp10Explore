using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp10Explore
{
    class CSharp8FeaturesExploration
    {
        //Default interface method
        interface IEmployee
        {
            void AddEmployee();
            void RemoveEmployee();

            void SubstituteEmployee() { Console.WriteLine("Default Interface Implementation"); }
        }
        public class Employee : IEmployee
        {
            public void AddEmployee()
            {
                Console.WriteLine("Adding");
            }

            public void RemoveEmployee()
            {
                Console.WriteLine("Removing");
            }
        }


    }
}
