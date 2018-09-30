using System;
using System.Collections.Generic;
using _3Extension;

namespace _3Extension
{
    class Program
    {
        public static void Main(string[] args)
        {

         
           List<String> nums = new List<String>() {"Hello","my","name","is","Nikita"};
         
            Console.WriteLine(nums.returnRandom());
            Console.WriteLine();
             nums.shuffle();
            nums.ForEach(Console.WriteLine);
        }
    }
}
