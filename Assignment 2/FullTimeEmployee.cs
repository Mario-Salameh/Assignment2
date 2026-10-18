using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public class FullTimeEmployee : Employee, IWorkable
    {
        private readonly decimal _monthlySalary;
        public FullTimeEmployee(int id,string name,decimal monthlySalary):base(id,name)
        {
            _monthlySalary = monthlySalary;

            EmploymentType = "Full Time";
        }
        
        public override decimal CalculateSalary()
        {
            return _monthlySalary;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working full-time.");
        }
    }
}
