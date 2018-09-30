using System;
using MathLib;

namespace _6Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         
         var c = new calc();
         System.Console.WriteLine(c.add(2,3)); //5

         var a = new int[] {1,5,12,-2};
         System.Console.WriteLine(c.add(a));   //16 
        }
    }
}
