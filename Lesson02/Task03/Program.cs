using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> desiredNumbers = GetFilteredList();

            Console.Clear();
            Console.WriteLine("The sum of elements is: " + desiredNumbers.Sum());
            Console.ReadKey();
        }

        private static List<int> GetFilteredList()
        {
            List<int> numbers = GetNumbersList();

            List<int> desiredNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (num > 0 && num % 2 != 0)
                {
                    desiredNumbers.Add(num);
                }
            }

            return desiredNumbers;
        }

        private static List<int> GetNumbersList()
        {
            int exitMarker = 1;
            List<int> numbers = new List<int>();

            do
            {
                Console.WriteLine("Enter number: (0 for exit)");
                string numberAsString = Console.ReadLine();
                int number;
                Int32.TryParse(numberAsString, out number);
                numbers.Add(number);

                if (number == 0)
                {
                    exitMarker = 0;
                }
            }
            while (exitMarker != 0);
            return numbers;
        }
    }
}
