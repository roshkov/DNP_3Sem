using System;

namespace _1StudentInher
{

    class DNPStudent : Student{

        public override void Hi(){
            
            Console.WriteLine("Hi, I'm a DNP student");
            base.Hi();
        }
    }

}