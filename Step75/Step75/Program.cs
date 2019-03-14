using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int numAge = Convert.ToInt32(yourAge);

            Console.WriteLine("Have you ever had a DUI? Answer true or false");
            string trueorfalseDUI = Console.ReadLine();
            bool boolDUI = Convert.ToBoolean(trueorfalseDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();
            int numTickets = Convert.ToInt32(yourTickets);

            Console.WriteLine("Are you qualified for C#ar Insurance?");
            bool qualified = (numAge > 15 && boolDUI == false && numTickets <= 3);
            Console.Write(qualified.ToString());
            Console.ReadLine();

        }
    }
}
