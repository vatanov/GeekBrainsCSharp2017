using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int effortCounter = 3;

            while (effortCounter > 0)
            {
                Console.Write("Enter login: ");
                string entredLogin = Console.ReadLine();
                Console.Write("Enter password: ");
                string entredPassword = Console.ReadLine();

                bool marker = IsUserAuthorized(entredLogin, entredPassword);

                if (marker == true)
                {
                    Console.WriteLine("You are authorized!");
                    break;
                }
                else
                {
                    Console.WriteLine("Login and/or password is incorrect. Please try again.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    effortCounter--;
                }
            }

            if(effortCounter == 0)
            {
                Console.WriteLine("You entered wrong login/password three times. System is blocked!");
            }
            Console.ReadKey();

        }

        private static bool IsUserAuthorized(string entredLogin, string entredPassword)
        {
            bool authPassed = false;

            string savedLogin = "root";
            string savedPassword = "GeekBrains";


            if (entredLogin == savedLogin && entredPassword == savedPassword)
            {
                authPassed = true;
            }

            return authPassed;
        }
    }
}
