using System;

namespace _2Polymorphism
{

    public class FullTimeEmployee : Employee{

        private double monthlySalary;
       


        public FullTimeEmployee(string name,double ms)
         :base(name)
          {
             monthlySalary=ms;
          }
        



         public override double GetMonthSalary()
         {
            return monthlySalary;
         }
    }


}
