using System;
using System.Reflection;


using _8Statics;

namespace _8Statics
{
    class Program
    {
        static void Main(string[] args)
        {
           
            gun g1= new gun();
            g1.shoot();

             gun g2= new gun();
            g2.shoot();
            g2.shoot();
            g2.shoot();


            Console.WriteLine(g1.getInfo());
            Console.WriteLine(g2.getInfo());

        }
    }
}
