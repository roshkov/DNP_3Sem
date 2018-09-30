using System;
using System.Collections.Generic;

namespace _3Extension
{
    static class MyExtensions
    {
        private static Random rnd = new Random();

    

        public static T returnRandom<T>(this List<T> list)
        {
            //(this List<T> list)
        
            return list[ rnd.Next(list.Count) ];
       
        }
    
    
        public static void shuffle<T>(this List<T> list)
        {

              int n = list.Count;  
            
            while (n > 1) {  
                n--;  
                int k = rnd.Next(n + 1);  
                T value = list[k];  
                list[k] = list[n];  
                list[n] = value;  
            }  
        }
    
    
    
    
    }
}
