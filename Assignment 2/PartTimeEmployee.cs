
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
            CheckEmploymentType("Part Time");
        }

        public override decimal CalculateSalary()
        {
            return _hourlyWorked * _hourlyRate;
        }

        
        public void Work()
        {
            if (EmploymentType != "Full Time" && EmploymentType != "Part Time")
            {
                Console.WriteLine($"{Name} has {EmploymentType}.");
                return;
            }
            Console.WriteLine($"{Name} is working {EmploymentType}.");
        }
    }
}
