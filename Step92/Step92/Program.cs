using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Package weight:");
            int weightPack = Convert.ToInt32(Console.ReadLine());

            if (weightPack > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Package height:");
                int heightPack = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Package length:");
                int lengthPack = Convert.ToInt32(Console.ReadLine());

                int total = weightPack + heightPack + lengthPack;

                if (total > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Environment.Exit(0);
                }

                else
                {
                    int product = total * weightPack;
                    int quotient = product / 100;
                    decimal quote = quotient;
                    string theQuote = String.Format("Your estimated total for shipping this package is: {0:C}", quote);
                    Console.WriteLine(theQuote);
                    Console.ReadLine();
                }

            

            }

        }
    }
}
