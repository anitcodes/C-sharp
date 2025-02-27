using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program to add to number from user input
            /* int num1;
             int num2;
             int sum;
             Console.Write("Enter the first number: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter the another number: ");
             num2 = Convert.ToInt32(Console.ReadLine());

             sum = num1 + num2;
             Console.WriteLine("Sum = " + sum);
            */

            //Conditional Statements
            //if else statement 

            /*
             // example1
             int a, b;
             Console.Write("Enter the first number: ");
             a = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter the another number: ");
             b = Convert.ToInt32(Console.ReadLine());
             if (a > b)
             {
                 Console.WriteLine("a is greater");
             }
             else
             {
                 Console.WriteLine("b is greater");
             }
            */

            //Write a program that takes an integer input and determines if it's even or odd.
            /*
            int num;
            Console.WriteLine("Enter a number to check Odd or Even : ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine(num + " is Even number");
            }
            else
            {
                Console.WriteLine(num + " is Odd number");

            }
            */

            //another method(short hand if else
            /*
            int num;
            Console.WriteLine("Enter a num : ");
            num = Convert.ToInt32(Console.ReadLine());
            string res = (num % 2 == 0) ? "Even number" : "Odd number";
            Console.WriteLine(res);
            */

            //if else if condition statements

            //Write a program that checks whether a given number is positive, negative, or zero
            /*
            try
            {
                int num;
                Console.WriteLine("Enter a number : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine("positive number");
                }
                else if (num < 0)
                {
                    Console.WriteLine("Negative number");
                }
                else
                {
                    Console.WriteLine("Zero");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input! Please enter the valid input");
            }
            */

            //Write a program that takes a character input and checks if it's a vowel (a, e, i, o, u) or a consonant.
            /*
            try
            {
                Console.Write("Enter a single character: ");
                string input = Console.ReadLine();

                // Check if input contains exactly one character
                if (input.Length != 1)
                {
                    throw new FormatException();
                }

                // Convert to a character
                char ch = char.ToLower(input[0]); // Convert to lowercase to handle uppercase vowels

                // Check if the character is a vowel
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    Console.WriteLine("Vowel letter");
                }
                else if (char.IsLetter(ch)) // Ensure it's an alphabetic letter
                {
                    Console.WriteLine("Consonant letter");
                }
                else
                {
                    Console.WriteLine("Not a valid alphabet character");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a single character.");
            }
            */

            //short hand if else

            /*
            int num = 20;
            string result = (num < 18) ? "Good Day" : "Bad Day";
            Console.WriteLine(result);
            */


            //Switch Case
            //when the user click on the number of a respective day they get that day

            /*
            int day;
            Console.WriteLine("Enter a number of a day : ");
            day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            */

        }
    }
}
