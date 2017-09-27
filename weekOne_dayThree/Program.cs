using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekOne_dayThree
{
    class Program
    {
        static void Main(string[] args)
        {

            //int firstNumber = 2;
            //int secondNumber = 6;

            //if ( firstNumber > secondNumber)
            //{
            //    //Do something
            //    Console.WriteLine("Bobo taught you math.");
            //}
            //else
            //{
            //    Console.WriteLine("Hello Hello. Good job");
            //}

            Console.WriteLine("What day is today?");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "Monday")
            {
                Console.WriteLine("Back to work");
            }

            else if (userAnswer == "Friday")
            {
                Console.WriteLine("TGIF");
            }

            else
            {
                Console.WriteLine("Just another day in paradise");
            }
        }
    }
}
