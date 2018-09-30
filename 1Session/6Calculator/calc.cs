namespace MathLib
{

 public class calc
 {
     public int add(int a, int b){
         return a+b;
     }
 
 
    public int add(int[] a){
        int c=0;
        foreach (int element in a)
        {
            c=c+element;
        }
        return c;
 
 
 }

}

}