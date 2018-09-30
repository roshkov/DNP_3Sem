using System;

namespace _6TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
           int score = 1342;
           string message="";

           message = (score>1337) ? "This is a new highscore!" : "You need more points to beat the highscore!";
           

            Console.WriteLine(message);

        }
    }
}
