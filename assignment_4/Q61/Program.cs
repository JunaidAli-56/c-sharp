using System;

namespace Q61
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10, b=20,c=15,d=8,e=40;
            int r=(a+b/(c-5))/((d+7)/(e-37)%3);
            Console.Write(r);
        }
          
            // {
            //    int a=10, b=20,c=15,d=8,e=40; 
            //   int r=a+b/c-5/d+7/e-37%3;
            //    Console.Write(r);
            // }

        //   {
        //        int a=10, b=20,c=15,d=8;
        //     int r=a*(b*b)-(c*b)+d;
        //     Console.Write(r);
        //   }
    }
}
