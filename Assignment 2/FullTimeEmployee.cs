
namespace Assignment_2
{
    public class FullTimeEmployee : Employee, IWorkable
    {
        private readonly decimal _monthlySalary;
        public FullTimeEmployee(int id,string name,decimal monthlySalary):base(id,name)
        {
            _monthlySalary = monthlySalary;

            CheckEmploymentType("Full Time");
        }
        
        public override decimal CalculateSalary()
        {
            return _monthlySalary;
        }

        public void Work()
        {

            if (EmploymentType != "Full Time" && EmploymentType != "Part Time")
            {
                Console.WriteLine($"{Name} has {EmploymentType}.");
                return;
            }
            Console.WriteLine($"{Name} is working {EmploymentType}");
        }
    }
}
