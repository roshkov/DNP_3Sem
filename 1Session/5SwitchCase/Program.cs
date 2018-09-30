using System;

namespace _5SwitchCase
{
    public class Program
    {
        static void Main(string[] args)
        {

         System.Console.WriteLine("enter num betwenn 0 - 10");   
         int caseSwitch = Convert.ToInt32(Console.ReadLine());
        
          while ((caseSwitch<0) || (caseSwitch>10))
         {
             Console.WriteLine("invalid input");
             caseSwitch = Convert.ToInt32(Console.ReadLine());
            
         }
         
         switch (caseSwitch)
         {
             case 0: Console.WriteLine("First");
             break;
         
             case 10: Console.WriteLine("Last");   
             break;

             default: Console.WriteLine(caseSwitch);    
             break;
         }

         
         
        } 
    }
}
