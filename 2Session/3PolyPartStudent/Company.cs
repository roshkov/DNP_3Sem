using System;
using System.Collections;
using System.Collections.Generic;

namespace _2Polymorphism
{

    public class Company{

        List<Employee> employs;
    

        public Company(){
             employs= new List<Employee>();
        }


        public double GetMonthlySalaryTotal(){
            double total = 0;
            foreach(var Employee in employs){
                total += (Employee.GetMonthSalary());
            }
            return total;
        }

        public void EmployNewEmployee(Employee newEmp){
            employs.Add(newEmp);
        }


        public int Getsize(){
            return employs.Count;
        }
    }


}