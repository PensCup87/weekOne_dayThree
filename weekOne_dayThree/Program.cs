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

            //Console.WriteLine("What day is today?");
            //string userAnswer = Console.ReadLine();

            //if (userAnswer == "Monday")
            //{
            //    Console.WriteLine("Back to work");
            //}

            //else if (userAnswer == "Friday")
            //{
            //    Console.WriteLine("TGIF");
            //}

            //else
            //{
            //    Console.WriteLine("Just another day in paradise");
            //}

            //Console.WriteLine("How old are you?");
            //int userAge = int.Parse(Console.ReadLine());

            //if (userAge >= 0 && userAge <= 1)
            //{
            //    Console.WriteLine("Just a baby");
            //}

            //else if (userAge > 1 && userAge < 4)
            //{
            //    Console.WriteLine("yay todlers");
            //}

            //else if (userAge >= 4 && userAge < 13)
            //{
            //    Console.WriteLine("Enjoy your childhood");
            //}

            //else if (userAge >= 13 && userAge < 65)
            //{
            //    Console.WriteLine("Life is awkward.");
            //}

            //else if (userAge >= 65 && userAge < 100)
            //{
            //    Console.WriteLine("Enjoy your retirement");
            //}

            //else
            //{
            //    Console.WriteLine("That's not really your age");
            //}

            //SWITCH STATEMENTS - checks for a single value, but has different format

            //Console.WriteLine("How many point did you earn?");
            //int pointsEarned = int.Parse(Console.ReadLine());

            //switch (pointsEarned)
            //{
            //    //case 0 is if the input is Zero
            //    case 0:
            //        Console.WriteLine("You loose");
            //        break;
            //    // case 1 is user entered 1
            //    case 1:
            //        Console.WriteLine("Needs Practice");
            //        break;
            //    //
            //    case 2:
            //        Console.WriteLine("On target");
            //        break;

            //    case 3:
            //        Console.WriteLine("Superstar");
            //        break;

            //    case 4:
            //        Console.WriteLine("Overachiever");
            //        break;

            //    //Each program NEEDS a Default to catch any values not mentioned

            //    default:
            //        Console.WriteLine("Invalid score entered");
            //        break;
            //        }

            //int guests = 4;
            Console.WriteLine("How many guests are eating?");
            int guests = int.Parse(Console.ReadLine());
            //int guestPaid = 13;
            Console.WriteLine("How much did each person pay?");
            int guestPaid = int.Parse(Console.ReadLine());

            float largeDiscountAmount = .90f;
            float smallDiscountAmount = .95f;
            float totalBill = (guests * guestPaid);
            float largeDiscountBill = totalBill * largeDiscountAmount;
            float smallDiscountBill = totalBill * smallDiscountAmount;

            if (totalBill >= 50)
            {
                Console.WriteLine("Your total is $" + largeDiscountBill);
            }

            else
            {
                Console.WriteLine("Your bill is $" + totalBill);
            }











        }
    }
}
