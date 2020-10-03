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
            Console.WriteLine("/**** Simple Calculator ****/ ");

            Console.WriteLine("Enter Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press 1 to Add, 2 to Subtract, 3 to Mulitply, 4 to Subtract");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
            }
            else if (Console.ReadLine() == "2")
            {
                Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
            }
            else if (Console.ReadLine() == "3")
            {
                Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
            }
            else if (Console.ReadLine() == "4")
            {
                Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
            }
            else
            {
                Console.WriteLine("Not a valid choice");
            }
            Console.ReadLine();


        }
    }
}
