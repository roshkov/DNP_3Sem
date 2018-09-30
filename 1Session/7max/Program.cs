using System;

namespace _7max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st num: ");
            int first = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("enter 2nd num: ");
            int second = Convert.ToInt32(Console.ReadLine());
        
    
        if(first>second){
            Console.WriteLine(first + " is bigger");    
        }
        else{
            if(second>first)
            {
                Console.WriteLine(second + " is bigger");
            }
            else{
                Console.WriteLine(first+" and "+second+" are equal");
            }
        }
        }
    }
}
