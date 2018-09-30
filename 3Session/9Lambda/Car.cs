using System;

namespace _9Lambda
{
    public class Car
    {
         public string color{get; set;}
         public double enginesize {get; set;}

         public double fuelEconomy {get; set;}



        public Car (string c, double es, double fe)
        {
                color=c;
                enginesize=es;
                fuelEconomy=fe;
        }



        public override string ToString(){
            return  "Color: "+color+"  Engine size: "+enginesize+ "  Fuel economy:  "
            +fuelEconomy ;

            
        }

    }
}