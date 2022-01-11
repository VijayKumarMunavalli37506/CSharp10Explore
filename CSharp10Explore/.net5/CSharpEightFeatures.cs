using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetExplore.net5
{

    class CSharpEightFeatures
    {
        //1. Default interface method
        //2.Using
        //3.Async Stream 
        //4.Static Local function
    }
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
