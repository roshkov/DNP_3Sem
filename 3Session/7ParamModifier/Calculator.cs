using System;

namespace _7ParamModifier
{
    public class Calculator
    {
        public int Add(params int[] list){

            int res=0;
            
            foreach(int element in list){
                res+=element;
            }
        
            return res;
        }
    }
}