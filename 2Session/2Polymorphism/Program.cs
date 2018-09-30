using System;

namespace _2Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var comp = new Company();
            Employee emp1 = new FullTimeEmployee("John",5000);
            Employee emp2 = new PartTimeEmployee("Michael",150.5,18);
            Employee emp3 = new PartTimeEmployee("Thomas",122.31,27);

            Console.WriteLine(comp.GetMonthlySalaryTotal());
            
            comp.EmployNewEmployee(emp1);
                  Console.WriteLine(comp.GetMonthlySalaryTotal());
            comp.EmployNewEmployee(emp2);
                  Console.WriteLine(comp.GetMonthlySalaryTotal());
            comp.EmployNewEmployee(emp3);
                  Console.WriteLine(comp.GetMonthlySalaryTotal());
        }
    }
}
