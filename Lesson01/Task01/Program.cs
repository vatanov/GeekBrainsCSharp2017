using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.Write("Enter your height: ");
            string height = Console.ReadLine();

            Console.Write("Enter your weight: ");
            string weight = Console.ReadLine();

            Console.WriteLine("First name: " + fName + "Last name: " + lName + "Age: " + age + "Height: " + height + "Weight: " + weight);
            Console.WriteLine("First name: {0}; Last name: {1}; Age: {2}; Height: {3}; Weight: {4}", fName, lName, age, height, weight);
            Console.WriteLine($"First name: {fName}; Last name: {lName}; Age: {age}; Height: {height}; Weight: {weight}");

            Console.ReadKey();
        }
    }
}
