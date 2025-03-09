// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace MyFirstApp
{
    class Program
    {
        /*
         Multiple line comment
         */
        static void Main(string[] args)
        {
            //Variables in C#

            /* string firstName = "Olawale";
             string lastName = "Dipo-Isijola";
             Console.WriteLine(firstName + " " + lastName);*/

            /*int myNum = 24;
            myNum = myNum + 1;
            Console.WriteLine(myNum);*/

            //const double pi = 3.142;

            //Reference type
            /*
             int[] scores = { 30, 40, 50 };
            int[] listOfScore = scores;

            listOfScore[0] = 100;


            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }

            foreach (var item in listOfScore)
            {
                Console.WriteLine(item);
            }
             */

            //How to get input from user

            /*Console.WriteLine("Hi, enter your username...");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);*/

            double firstNumber, lastNumber, result = 0;
            char operation;

            Console.WriteLine("Enter the first number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /):");
            operation = Console.ReadLine()[0];

            Console.WriteLine("Enter the last number:");
            lastNumber = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = firstNumber + lastNumber;
                    break;
                case '-':
                    result = firstNumber - lastNumber;
                    break;
                case '*':
                    result = firstNumber * lastNumber;
                    break;
                case '/':
                    result = firstNumber / lastNumber;
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    return;
            }

            Console.WriteLine("The result is: " + result);

        }
    }
}
