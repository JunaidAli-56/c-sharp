using System;

namespace Q53
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=20, y=35;
            x=y++ + x++;
            y=++y + ++x;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        // {
        //     int x=10, y=15, a,b;
        //     a= x++;
        //     b= ++y ;
        //     Console.WriteLine(x);
        //     Console.WriteLine(y);
        // }

        // {
        //     int a=10;
        //     a++;
        //     Console.WriteLine(a);
            
        // }

        // {
        //     int a=10;
        //      Console.WriteLine(a++);
            
        // }

        // {
        //     int n=10,x=0;
        //     x=n--;
        //     Console.WriteLine(x);
        // }

        // {
        //     int i=5, j=6, k=7, n=3;
        //     Console.WriteLine(i+j*k-k%n);
        //     Console.WriteLine(i/n);

        // }
       

        // { 
        //     float  x=3.8F;
            
        //     Console.WriteLine((int)x);
        // }

        // {
        //     int a=6;
        //     Console.WriteLine(a);
        //     a=a+3;
        //     Console.WriteLine(a);
        //     a-=5;
        //     Console.WriteLine(a);
        //     a++;
        //     Console.WriteLine(a);
        // }
    }
}
