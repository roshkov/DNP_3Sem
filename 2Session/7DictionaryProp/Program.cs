using System;
using System.Collections.Generic;

namespace _7DictionaryProp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person p1= new Person("Alex",25,10);
            Person p2= new Person("John Cena",30,999);
            Person p3= new Person("Diana",18,15.22);

            Dictionary<string, Person> nicknames = new Dictionary<string, Person>();
        
            nicknames.Add("potato",p1);
            nicknames.Add("daBoss",p2);
            nicknames.Add("muah",p3);
        

            Console.WriteLine(nicknames["muah"].ToString()); //getting value by 
                                                             //the key
                                                             //in this case it     
        }                                                    // is of type string 
    }
}

