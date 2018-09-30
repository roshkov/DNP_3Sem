using System;
using System.Collections.Generic;

namespace _2InterfacesGen
{
    class Bomb<T> :IExplodable<T>
    {
      
     public void Explode(T radius){
           if (radius.GetType() == typeof(double)){
           Console.WriteLine("Boom!"+radius);
           }
      }
      
      
      
    }
}
