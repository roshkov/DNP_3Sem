using System;

namespace _2Polymorphism
{
    public abstract class Employee{
       private string name;

        public Employee(string name){
            this.name= name;
        }
    

        public abstract double GetMonthSalary();
    
    }

}