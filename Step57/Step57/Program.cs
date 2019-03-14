using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //questions:
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You are on the " + courseName + "course");

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("You are on page number: " + pageNum);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool truefalseHelp = Convert.ToBoolean(needHelp);
            Console.WriteLine("Do you need help: " + truefalseHelp);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine(positiveExperiences);

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string provideFeedback = Console.ReadLine();
            Console.WriteLine("Feedback: " + provideFeedback);

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int numHours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Hours Studied: " + numHours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
            Environment.Exit(0);

        }
    }
}
