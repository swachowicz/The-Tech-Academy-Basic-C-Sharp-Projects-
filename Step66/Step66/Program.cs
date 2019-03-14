using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to be multiplied by 50:");
            string inputNumber = Console.ReadLine();
            int inNum = Convert.ToInt32(inputNumber);
            int total = inNum * 50;
            Console.WriteLine(inputNumber + " times 50 is: " + total);

            Console.WriteLine("Type a number to be added to 25:");
            string addNumber = Console.ReadLine();
            int addNum = Convert.ToInt32(addNumber);
            int addtotal = addNum + 25;
            Console.WriteLine(addNumber + " plus 25 is: " + addtotal);

            Console.WriteLine("Type a number to be divided by 12.5:");
            string divideNumber = Console.ReadLine();
            int divideNum = Convert.ToInt32(divideNumber);
            double quotient = divideNum / 12.5;
            Console.WriteLine(divideNum + " divided by 12.5 is: " + quotient);

            Console.WriteLine("Type a number to check if greater than 50: ");
            string greaterThan = Console.ReadLine();
            int gr8Than = Convert.ToInt32(greaterThan);
            bool trueOrFalse = gr8Than > 50;
            Console.Write(trueOrFalse.ToString());

            Console.WriteLine("Type a number view the remainder of that number when divided by 7: ");
            string divideRemainder = Console.ReadLine();
            int divideRemain = Convert.ToInt32(divideRemainder);
            int remainder = divideRemain % 7;
            Console.WriteLine(remainder);



            Console.ReadLine();




        }
    }
}
