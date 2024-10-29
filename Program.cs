using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            int ageconverted = Convert.ToInt32(age);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + ageconverted);

            if (ageconverted < 0 || ageconverted > 150)
            {
                Console.WriteLine("Invalid age");
            }

            Console.ReadLine();

            //if ELSE STATEMENT IN C#
            Console.Write("Enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int answer = firstNumber * secondNumber;

            Console.WriteLine();

            Console.WriteLine("Enter the answer: ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer == answer)
            {
                Console.WriteLine("Thats Correct");
            }
            else
            {
                Console.WriteLine("Close but not right");
            }
            Console.WriteLine("The Value of " + firstNumber + " multiplied by " + secondNumber + " = " + answer);


            //switch STATEMENT
            Console.WriteLine("Enter the date of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please enter a valid day of the week");
                    break;
            }

            //ITERATION
            //WHILE
            int number = 5;
            while (number < 10)
            {
                Console.WriteLine("The number is " + number);
                number++;
            }

            //FOR LOOP
            Console.Write("Enter the number of times you want to loop ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if(loopCounter <= 0)
            {
                Console.WriteLine("Please enter a number more than 1");
            }
            else
            {
            for (int i = 0; i < loopCounter; i++) {
                Console.WriteLine("Hello number " + i);
            }

            }


            Console.ReadLine();
        }
    }
}
