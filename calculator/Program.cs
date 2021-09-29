using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            int sum = 0;

            for (int i = 0; i < 3; i++) 

                Console.WriteLine("sisesta number");
            int Usernumber = Convert.ToInt32(Console.ReadLine());
            sum = sum + Usernumber;
            Console.WriteLine($"your result is{sum} ");







        }
    }
}
