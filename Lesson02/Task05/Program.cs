using System;
using System.Threading; 

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO!");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("You are using IMT Calculator ver. 0.0.1");
            Thread.Sleep(3000);
            Console.Clear();

            int exitMarker = 0;

            do
            {
                double height = GetHeight();
                if (height == 0)
                {
                    exitMarker = 1;
                    break;
                }

                double weight = GetWeight();
                double imt = GetImt(height, weight);
                Console.WriteLine("Your IMT is " + imt);

                double perfectWeight = GetPerfectWeihgt(height);

                if (imt < 20)
                {
                    double diff = perfectWeight - weight;
                    Console.WriteLine($"You are too skinny, you need to add {diff} kilos.");
                }
                else if (imt >= 20 && imt <= 25)
                {
                    Console.WriteLine("Don't worry, your weight is normal.");
                }
                else if (imt > 25 && imt <= 35)
                {
                    double diff = weight - perfectWeight;
                    Console.WriteLine($"You are quite overweight, you need to lose weight for {diff} kilos.");
                }
                else
                {
                    double diff = weight - perfectWeight;
                    Console.WriteLine($"You are too overweight, you need to lose weight for {diff} kilos. But better kill yourself.");
                }

                Console.WriteLine("Press [Enter] to continue...");
                Console.ReadKey();

                Console.Clear();
            }
            while (exitMarker == 0);
        }

        private static double GetPerfectWeihgt(double height)
        {
            return 22.5 * (Math.Pow(height, 2));
        }

        private static double GetImt(double height, double weight)
        {
            return weight / (Math.Pow(height, 2));
        }

        private static double GetWeight()
        {
            Console.Write("Enter you weight in kilos: ");
            double weight = Double.Parse(Console.ReadLine());
            return weight;
        }

        private static double GetHeight()
        {
            Console.Write("Enter you height in meters (0 for exit): ");
            double height = Double.Parse(Console.ReadLine());
            return height;
        }
    }
}
