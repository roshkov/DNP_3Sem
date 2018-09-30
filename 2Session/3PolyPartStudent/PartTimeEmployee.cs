using System;

namespace _2Polymorphism
{

    public class PartTimeEmployee : Employee{

        private double hourlyWage;
        private int hoursPerMonth;


        public PartTimeEmployee(string name,double hw,int hpm)
         :base(name)
          {
              hourlyWage=hw;
              hoursPerMonth=hpm;

          }
        



         public override double GetMonthSalary()
         {
         return hourlyWage*hoursPerMonth;
         }
    }


}
