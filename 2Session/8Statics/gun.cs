using System;

namespace _8Statics
{
    public class gun
    {
        static int gunCount=0;
        static int bulletCount=0;
        int shotsFired=0;

        public gun(){
            gunCount++;

        }

        public void shoot(){
            Console.WriteLine("BANG!");
            bulletCount++;
            shotsFired++;
        }
    
        public string getInfo(){
            return "gunCount="+gunCount+"  bulletCount="+bulletCount+"  shotsFired"+shotsFired;
        }
       
    }
}