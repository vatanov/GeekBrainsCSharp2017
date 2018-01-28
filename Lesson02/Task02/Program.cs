using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter number: ");
            string s = Console.ReadLine();
            Int32.TryParse(s, out num);

            int count = NumberCounter(num);

            Console.WriteLine($"Amount of numbers in {num} is {count}");

            Console.ReadKey();
        }

        static int NumberCounter(int a)
        {
            int count = 0;

            while(a > 0)
            {
                count++;
                a = a / 10;
            }

            return count;
        }
    }
}
