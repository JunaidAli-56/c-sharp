using System;

namespace Q55
{
    class Program
    {
        static void Main(string[] args)
        // {
        //     int a=3, b=4;
        //     ++a*=b++;
        //     Console.WriteLine(a);
        //     Console.Read();
        // }

        // {
        //     int a=3, b=4;
        //     a++; a*= ++b;
        //     Console.WriteLine(a);
        //     Console.Read();
        // }
        
        {
           int a=3, b=4;
             a=a+1; b=b+1;
             b=b+1; a=a+1;
             a=a*b; a=a*b;
             Console.WriteLine(a);
             Console.Read(); 
        }
        
    }
}
