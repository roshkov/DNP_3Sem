using System;

namespace _4Overloading
{
    public class Player
    {
      public void Shout(string s){
          Console.WriteLine(s);
      }



      public void Shout(int i){
          Console.WriteLine(i+" is my lucky number");
      }



      public void Shout(Enemy e){
          Console.WriteLine("The enemy can do "+e.damage+" damage to me");
      }


    }
}