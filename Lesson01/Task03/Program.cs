using System;

namespace Task03
{
    class Program
    {
        static double GetResult (int x1, int y1, int x2, int y2) 
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(x2 - x1, 2));
            return result;
        }
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 2;

            int x2 = 3;
            int y2 = 4;

            Console.WriteLine(GetResult(x1,y1,x2,y2));
        }
    }
}
