using System;
using System.Collections.Generic;

namespace _1GenericStack
{
    class Program
    {
   
   
        public static void pushToStack<T>(Stack<T> s, params T[] list)
        {
           foreach(var item in list)   {
                s.Push(item);
            }  
           // Console.WriteLine(s.ToString()); 
        }
   
        static void Main(string[] args)
        {
            

         Stack<int> nums = new Stack<int>();
         Stack<string> s = new Stack<string>();


           //Stack<T> stack = new Stack<T>();
            
        
             int[] a1 = new int[] { 3, 4, 5 };
             pushToStack(nums,a1); 
              
             string[] a2 = new string[] {"yoyoyo", "bus", "i dont know","i wanna sleep"};   
            pushToStack(s,a2); 
               
               foreach(int value in nums)   {
                Console.WriteLine(value);
               }

                foreach(string value in s)   {
                Console.WriteLine(value);
               }
        }
    }
}
