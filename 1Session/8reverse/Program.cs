using System;

namespace _8reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write your name");
            string name = Console.ReadLine();
            var a = new char[name.Length];
            
            for(int i=0; i<name.Length; i++ ){
                a[i]= name[name.Length-1-i];
            }
            
            name="";
            for(int i=0; i<a.Length; i++){
                name = name + a[i];
            }
            
            Console.WriteLine(name);
        
        }
    }
}
