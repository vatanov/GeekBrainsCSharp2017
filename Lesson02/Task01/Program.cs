using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = GetNumber();
            int b = GetNumber();
            int c = GetNumber();

            Console.WriteLine("Minimal number is " + (MinNumber(a, b, c)));

            Console.ReadKey();
        }

        static int GetNumber()
        {
            int n = 0;

            Console.Write("Enter number: ");
            string s = Console.ReadLine();

            Int32.TryParse(s, out n);

            return n;
        }

        static int MinNumber(int a, int b, int c)
        {
            int min = 0;

            if (a < b && a < c) min = a;
            else if (b < a && b < c) min = b;
            else if (c < a && c < b) min = c;

            return min;
        }
    }
}
