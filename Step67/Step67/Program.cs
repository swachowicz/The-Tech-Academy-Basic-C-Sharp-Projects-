using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate:");
            string hourlyRate = Console.ReadLine();
            int hourRate = Convert.ToInt32(hourlyRate);
            Console.WriteLine("Hours worked per week:");
            string workedHours = Console.ReadLine();
            int numHours = Convert.ToInt32(workedHours);
            int weekly = hourRate * numHours;
            int product = weekly * 52;


            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate:");
            string hourlyRateII = Console.ReadLine();
            int hourRateII = Convert.ToInt32(hourlyRateII);
            Console.WriteLine("Hours worked per week:");
            string workedHoursII = Console.ReadLine();
            int numHoursII = Convert.ToInt32(workedHoursII);
            int weeklyII = hourRateII * numHoursII;
            int productII = weeklyII * 52;

            Console.WriteLine("Annaul salary of Person 1: " + product);
            Console.WriteLine("Annaul salary of Person 2: " + productII);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = product > productII;
            Console.Write(trueOrFalse.ToString());

            Console.ReadLine();

        }
    }
}
