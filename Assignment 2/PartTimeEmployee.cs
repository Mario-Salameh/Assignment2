using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public class PartTimeEmployee: Employee,IWorkable
    {
        private readonly decimal _hourlyWorked;
        private readonly decimal _hourlyRate;
        public PartTimeEmployee(int id,string name,decimal hoursWorked,decimal hourlyRate) : base(id,name)
        {
            _hourlyWorked = hoursWorked;
            _hourlyRate = hourlyRate;
            EmploymentType = "Part Time";
        }

        public override decimal CalculateSalary()
        {
            return _hourlyWorked * _hourlyRate;
        }


        public void Work()
        {
            Console.WriteLine($"{Name} is working part-time.");
        }
    }
}
