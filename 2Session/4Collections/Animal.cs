using System;
using System.Collections;
namespace _4Collections
{
    class Animal :IComparable<Animal>
    {
    
        string type;
        double weight;
        int speed;


        public Animal(string type,double weight,int speed){
            this.type=type;
            this.weight=weight;
            this.speed=speed;
        }


        public override string ToString(){
           return("type: "+type+", weight: "+weight+
            ", speed: "+speed);
        }
    
    
         public int CompareTo(Animal next){
                 return next.speed.CompareTo(this.speed);  //change this line to 
          }                                                //change sort parameter 
    }
}