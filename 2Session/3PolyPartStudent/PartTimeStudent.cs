using System;

namespace _2Polymorphism
{

    public class PartTimeStudent : PartTimeEmployee, IStudent{

        int year=0;
        public PartTimeStudent(string name,double hw,int hpm)
         :base(name,hw,hpm)
          {
          }

            public void Register(int year)
            {
                this.year=year;
            }


        public override double GetMonthSalary()
       
         {
          //Console.WriteLine("test");
          return base.GetMonthSalary();
          
         }
        
    }
}