using System;
// class Week4homework {

// static int largest(int a, int b){

// if(a>b){

// return a;
// }
// else if(b>a){
// return b;
// }
// else{
// return -1;
// }
// }

// static void Main() {
// int a = 3, b=5;

// int lar = largest( a, b);

// Console.WriteLine("\nLargest Number is : "+lar);
// }

// }

public class Week4homework2
{  
    static void pattern(int N,string shape){
    int i,j,k; //declaring the variables to use
    if(shape=="left"){
       for(i=1;i<=N;i++)
       {
    	for(j=1;j<=i;j++)
    	   Console.Write("*"); 
    	Console.Write("\n");
       }
      }
    else if(shape=="right"){

     for (i = 1; i <= N; i++)  
         {  
            for (j = 1; j <= N-i; j++)  
            {Console.Write(" ");}  
            for (k = 1; k <= i; k++)  
            {  Console.Write("*");}  
            Console.WriteLine("");  }  
        Console.ReadLine();}
    }
    public static void Main() 
{//main method
   int N; 
   string shape; 
   Console.Write("Input N: ");
   N= Convert.ToInt32(Console.ReadLine()); 
   Console.Write("Input shape: ");
   shape= Console.ReadLine(); 
   Console.Write("N is: "+N+"; shape is "+shape+"\n"); 
   pattern(N,shape);
}

}