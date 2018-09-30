using System;

namespace _4EvenUneven
{
    class Program
    {
        static void Main(string[] args)
        {
          System.Console.WriteLine("Even numbers:");
           for(int i=0; i<100; i++){
              if ( (i & 1) == 0 ) 
                {
                    System.Console.WriteLine(i);
                }
           
        }
        
         System.Console.WriteLine("UnEven numbers:");
        int j=0;
        while(j<100){
            if (!( (j & 1) == 0 )){
               System.Console.WriteLine(j);  
        
            }
        j++; 
        
        
        }
    }}
}
