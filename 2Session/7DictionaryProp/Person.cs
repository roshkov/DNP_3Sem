using System;
using System.Collections;

namespace _7DictionaryProp
{
    public class Person
    {
      string Name;
      int Age;

        double power;


        public Person(string n, int a, double p){
            Name=n;
            Age=a;
            power=p;
       }

        override public string  ToString(){
            return (Name+"  "+Age+"   "+power);
        }
}
}

   