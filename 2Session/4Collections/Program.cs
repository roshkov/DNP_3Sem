using System;
using System.Collections.Generic;


namespace _4Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           
             List<Animal> animalList = new List<Animal>();
                
                var animal1=new Animal("rhino",400,10);
                 var animal2=new Animal("giraffe",900,12);
                 var animal3=new Animal("elephant",800,7);
                animalList.Add(animal1);
                animalList.Add(animal2);
                animalList.Add(animal3);
                //creating list with animals

           
            foreach(var Animal in animalList){
                Console.WriteLine(Animal.ToString());
            }
            //printing all animals


            animalList.Sort();

          Console.WriteLine("lalalalalala=====");
             foreach(var Animal in animalList){
                Console.WriteLine(Animal.ToString());
            }
            
            
            
        }
       
        



        
    }
}
