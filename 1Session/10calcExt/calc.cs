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

    public int subtract(int a, int b){
        return a-b; 
    }


    public int multiply(int a, int b){
        return a*b;
    }
    
    
    public dynamic divide(int a,int b){
        if (b==0){
            return "invalid input";
        }
        return a/b;

    }
    
    
    
}

}