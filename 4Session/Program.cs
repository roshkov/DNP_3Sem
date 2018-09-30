using System;
using System.IO;
namespace _4Session
{
    class Program
    {
        static void Main(string[] args)
        {


            using(var sr = new StreamReader("file.txt"))
            {
             
             char[] charsToTrim = { '.', '?', '!', ' ', ';', ':', ',' };
             string[] fields=null;
             int counter = 0;
              //int total_words = source.Count();
             
                string line;
                while ( (line = sr.ReadLine() ) != null)
                {
                    line.Trim();
                    fields = line.Split(charsToTrim,StringSplitOptions.RemoveEmptyEntries);
                  
                
                
                }
               
            sr.Close();
            Console.WriteLine("number of words="+counter);

            }

        }
    }
}
