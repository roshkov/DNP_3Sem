using System;

namespace _5OperatorOverload
{
    public class Time
    {
        int Hours {get; set;}
        int Minutes {get; set;}
    

        public Time(int h, int m){
            Hours = h;
            Minutes = m;
        }
    
    
        
    
        public static Time operator + (Time t1, Time t2){
            
            int finM = (t1.Minutes+t2.Minutes)%60 ;
            int finH = t1.Hours+t2.Hours + (t1.Minutes+t2.Minutes)/60 ;

            return (new Time(finH, finM));
        }


        public static Time operator + (Time t1, int min){

            int finM = (t1.Minutes+min)%60 ;
            int finH = t1.Hours+0 + (t1.Minutes+min)/60 ;

          return (new Time(finH, finM));   
        }



        public override string ToString(){
            return "Hours: "+Hours+"  Minutes: "+Minutes ;
        }
    }




}