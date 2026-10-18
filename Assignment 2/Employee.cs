using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Assignment_2
{
    public abstract class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }

        private decimal _Salary { get; set; }

        public decimal Salary { get { return _Salary; } }

        public string EmploymentType { get; set; }
        public Employee(int id,string name)
        {
            Id = id;
            Name = name;
        }

        
        public void CheckEmploymentType(string employmenttype)
        {
            if (employmenttype != "Full Time" && employmenttype != "Part Time")
            {
                EmploymentType = "Invalid Employment Type";
                return;
            }
            
                EmploymentType = employmenttype;
            
           
        }

        public abstract decimal CalculateSalary();
       

        public void DisplayInfo()
        {
            _Salary = CalculateSalary();

            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Employee Type: {EmploymentType}");
            Console.WriteLine($"Salary: {Salary} JOD");
        }

    }
}
