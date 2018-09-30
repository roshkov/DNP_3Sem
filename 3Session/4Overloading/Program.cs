using System;

namespace _4Overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemy e = new Enemy(5);
            Player p1 = new Player();
            p1.Shout("piska");
            p1.Shout(19);
            p1.Shout(e);
           // Console.WriteLine("Hello World!");

        }
    }
}
