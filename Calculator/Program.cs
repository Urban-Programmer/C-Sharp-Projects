using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This Program allows to the user to perform simple integer calculations */
            /* This Version includes a loop */

            Console.WriteLine("/**** Simple Looping Calculator ****/ ");

            while (true) {

                Console.WriteLine("Press 1 to Add, 2 to Subtract, 3 to Mulitply, 4 to Divide");
                Console.WriteLine("Your Choice: ");
                string userChoice = Console.ReadLine();

                Console.WriteLine("Enter Number 1: ");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Number 2: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                if (userChoice == "1")
                {
                    Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
                }
                else if (userChoice == "3")
                {
                    Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
                }
                else if (userChoice == "4")
                {
                    Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
                }
                else
                {
                    Console.WriteLine("Not a valid choice");
                }

                Console.WriteLine("Press n to quit, otherwise press any key to continue.");
                if (Console.ReadLine().ToLower() == "n")
                {
                   break;
                }


            }






        }
    }
}
