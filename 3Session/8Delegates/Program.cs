using System;

namespace _8Delegates
{
    class Program
    {
      public delegate void notifier(string s);


        public static void SayHello(string s)
        {
            Console.WriteLine("Hello, "+s);
        }


        public static void SayGoodbye(string s)
        {
            Console.WriteLine("Goodbye, "+s);
        }


        static void Main(string[] args)
        {
          
          notifier not = SayHello;
          not("Pidor");
            
            not = SayGoodbye;
            not("Pidor");
          
        }
    }
}
