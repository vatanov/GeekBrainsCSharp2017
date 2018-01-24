using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your height in meters: ");
            string h = Console.ReadLine();
            double height;
            double.TryParse(h, out height);

            Console.Write("Enter your weight in kilos: ");
            string w = Console.ReadLine();
            double weight;
            double.TryParse(w, out weight);

            double index = weight / (height * height);
            
            Console.WriteLine($"Your index is: {index:F2}");
            
            Console.ReadKey();
        }
    }
}
