
using Assignment_2;

for(int i = 0; i < 2; i++) {
    
    int EmployeeId = Helper.IncreaseCounter();
    Console.WriteLine("Enter Your Name");
    string fullName = Console.ReadLine();
    Console.WriteLine("Enter Employment Type ( 1 for Full Time, 2 for Part Time");
    int EmploymentType = Convert.ToInt32(Console.ReadLine());
    
   
    if (EmploymentType == 1)
    {
        Console.WriteLine("Enter Your Salary");
        int Salary = Convert.ToInt32(Console.ReadLine());

        FullTimeEmployee fullTime = new FullTimeEmployee(EmployeeId, fullName, Salary);
        fullTime.DisplayInfo();
        fullTime.Work();
    }

    else if (EmploymentType == 2)
    {
        Console.WriteLine("Enter Your hourly worked");
        int HoursWorked = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Your hourly Rate");
        int HoursRate = Convert.ToInt32(Console.ReadLine());
        PartTimeEmployee partTime = new PartTimeEmployee(EmployeeId, fullName, HoursWorked, HoursRate);

        partTime.DisplayInfo();
        partTime.Work();

    }

    else
    {
        Console.WriteLine("Invalid Employment Type. Please enter 1 or 2.");
    }

}






