using System;
using System.Collections.Generic;
using System.Text;

namespace W8_ClassExample
{
    public abstract class Employee
    {
        public string FirstName { get; set; } 
   
        public string LastName { get; set; }

        public int SIN { get; set; }

        public abstract double CalculatePayroll();


    }
}
