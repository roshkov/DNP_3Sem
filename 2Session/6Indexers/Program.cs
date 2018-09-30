using System;
using System.Collections;

namespace _6Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime enterDate = new DateTime(2018, 9, 1, 14, 20, 0);

            Schedule s = new Schedule();
        
            Console.WriteLine( s.returnValue(enterDate)); //passing DateTime
        
       
        string dt = "2018-09-03 08:00:0";
        Console.WriteLine( s.returnValue(dt));  //passing string
        
        }
    }
}
