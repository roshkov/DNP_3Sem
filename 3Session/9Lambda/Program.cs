using System;
using System.Collections.Generic;

namespace _9Lambda
{
    class Program
    {

       public delegate bool Predicate<in T>(T obj); //hz
        
 
        public static bool hasBlueColor(Car car)
        {
            return car.color.Equals("blue");
        }


        static void Main(string[] args)
        {
           List<Car> list = new List<Car>();
        
            Car c1= new Car("blue", 5.5 , 20.1);
               Car c2= new Car("white", 1.9 , 6.5);
                  Car c3= new Car("blue", 1.8 , 8.5);

                  list.Add(c1);
                  list.Add(c2);
                  list.Add(c3);
                  
                  Predicate<Car> del = hasBlueColor;
                  Console.WriteLine ( del(c1) );

           


            // var selectedColor = list.FindAll(hasBlueColor);
            // foreach(Car element in selectedColor){

            // Console.WriteLine(element.ToString());
            }
        }
    }
}
