using System;
using System.Collections.Generic;

namespace _1GenericStack
{
    class Program
    {
   
   
        public static void pushToStack<T>(Stack<int> s, params T list)
        {
           //foreach(var item in list)   {
            //    s.Push(item);
            //}  
            Console.WriteLine(s.ToString()); 
        }
   
        static void Main<T>(string[] args)
        {
            

         Stack<int> nums = new Stack<int>();

         Stack<string> s = new Stack<string>();


            //Stack<T> stack = new Stack<T>();
            
        
             int[] a1 = new int[] { 3, 4, 5 };
             pushToStack(nums,a1); 


        }
    }
}
