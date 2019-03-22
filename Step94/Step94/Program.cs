using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("History Practice Exam:");
            Console.WriteLine("When did the First World War begin?");
            int number = Convert.ToInt32(Console.ReadLine());
            /*bool isGuessed = false;*/

            /* comparison expression: */
            bool isGuessed1 = number == 1939;
            /* !isGuessed is the same as isGuessed = false; */

            /*this will happen at least once, then go to while loop, accounts for 12 being true*/
            do
            {
                switch (number)
                {
                    case 1943:
                        Console.WriteLine("You guessed 1943. Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1935:
                        Console.WriteLine("You guessed 1935. Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1939:
                        Console.WriteLine("You guessed 1939. That is correct!");
                        isGuessed1 = true;
                        break;
                    default:
                        Console.WriteLine("That's incorrect. Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed1);

            Console.WriteLine("History Practice Exam:");
            Console.WriteLine("When did the First World War end?");
            int number2 = Convert.ToInt32(Console.ReadLine());
            /*bool isGuessed = false;*/

            /* comparison expression: */
            bool isGuessed2 = number2 == 1945;
            /* !isGuessed is the same as isGuessed = false; */

            /*this will happen at least once, then go to while loop, accounts for 12 being true*/
            do
            {
                switch (number)
                {
                    case 1943:
                        Console.WriteLine("You guessed 1943. Try again.");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1935:
                        Console.WriteLine("You guessed 1963. Try again.");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1939:
                        Console.WriteLine("You guessed 1945. That is correct!");
                        isGuessed2 = true;
                        break;
                    default:
                        Console.WriteLine("That's incorrect. Try again.");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }

            while (!isGuessed2);

            Console.Read();
        }
    }
}


