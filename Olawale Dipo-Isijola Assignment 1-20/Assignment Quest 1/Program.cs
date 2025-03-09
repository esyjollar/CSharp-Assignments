using System;
using System.Globalization;

namespace Assignment_Quest_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Please uncomment the code to run the program


            //Question 1
            /*Write a program and ask the user to enter a number. The number
should be between 1 to 10. If the user enters a valid number, display
"Valid" on the console. Otherwise, display "Invalid". (This logic is used a
lot in applications where values entered into input boxes need to be
validated.)
*/

            /*Console.WriteLine("Enter a number between 1 to 10: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 10)
{
    Console.WriteLine("Valid");
}
else
{
    Console.WriteLine("Invalid");
}*/




            /*Write a program which takes two numbers from the console and displays the maximum of the two.
             */

            /* Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First number is greater than second number");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("Second number is greater than first number");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }*/



            /*Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
            */

            /*Console.WriteLine("Enter the width of an image: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of an image: ");
            int height = Convert.ToInt32(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("The image is landscape");
            }
            else if (width < height)
            {
                Console.WriteLine("The image is portrait");
            }
            else
            {
                Console.WriteLine("The image is square");
            }*/



            /*- Your job is to write a program for a speed camera. For simplicity,
ignore the details such as camera, sensors, etc and focus purely on the
logic. Write a program that asks the user to enter the speed limit. Once
set, the program asks for the speed of a car. If the user enters a value
less than the speed limit, program should display Ok on the console. If
the value is above the speed limit, the program should calculate the
number of demerit points. For every 5km/hr above the speed limit, 1
demerit points should be incurred and displayed on the console. If the
number of demerit points is above 12, the program should display
License Suspended.*/

            /*Console.WriteLine("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of a car: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit Points: " + demeritPoints);
                }
            }*/






            //Question 2

            /*Write a program to count how many numbers between 1 and 100 are
            divisible by 3 with no remainder. Display the count on the console.*/

            /*int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Total numbers between 1 and 100 which are divisible by 3 with no remainder: " + count);*/



            /*Write a program and continuously ask the user to enter a number or
            "ok" to exit. Calculate the sum of all the previously entered numbers
            and display it on the console*/

            /*int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all the previously entered numbers: " + sum);*/



            /*Write a program and ask the user to enter a number. Compute the
            factorial of the number and print it on the console. For example, if the
            user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display
            it as 5! = 120.*/

            /*Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(number + "! = " + factorial);*/



            /*Write a program that picks a random number between 1 and 10. Give
            the user 4 chances to guess the number. If the user guesses the
            number, display “You won"; otherwise, display “You lost". (To make sure
            the program is behaving correctly, you can display the secret number on
            the console first.)*/

            /*Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int chances = 4;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a number between 1 to 10: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == randomNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    chances--;
                    Console.WriteLine("You lost. Chances left: " + chances);
                }
            }
            if (chances == 0)
            {
                Console.WriteLine("You lost");
            }   */



            /*Write a program and ask the user to enter a series of numbers
            separated by comma. Find the maximum of the numbers and display it
            on the console. For example, if the user enters “5, 3, 8, 1, 4", the
            program should display 8*/

            /*Console.WriteLine("Enter a series of numbers separated by comma: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int max = Convert.ToInt32(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                int number = Convert.ToInt32(numbers[i]);
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Maximum number: " + max);*/




            //Question 3

            /* When you post a message on Facebook, depending on the number of
                people who like your post, Facebook displays different information.
                • If no one likes your post, it doesn't display anything.
                • If only one person likes your post, it displays: [Friend's Name] likes
                your post.
                • If two people like your post, it displays: [Friend 1] and [Friend 2]
                like your post.
                    • If more than two people like your post, it displays: [Friend 1],
                [Friend 2] and [Number of Other People] others like your post.
                Write a program and continuously ask the user to enter different
                names, until the user presses Enter (without supplying a name).
                Depending on the number of names provided, display a message based
                on the above pattern..*/




            /*Write a program and ask the user to enter their name. Use an array
            to reverse the name and then store the result in a new string. Display
            the reversed name on the console.
            */


            /*Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reversedName = new string(nameArray);
            Console.WriteLine("Reversed name: " + reversedName);

           
            
            /*- Write a program and ask the user to enter 5 numbers. If a number
            has been previously entered, display an error message and ask the user
            to re-try. Once the user successfully enters 5 unique numbers, sort
            them and display the result on the console.
            */


            /*- Write a program and ask the user to continuously enter a number or
            type "Quit" to exit. The list of numbers may include duplicates. Display
            the unique numbers that the user has entered.*/

            /*HashSet<int> uniqueNumbers = new HashSet<int>();

            while (true)
            {
                Console.WriteLine("Enter a number (or type 'Quit' to exit): ");
                string input = Console.ReadLine();

                if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    uniqueNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or type 'Quit' to exit.");
                }
            }

            Console.WriteLine("Unique numbers entered: " + string.Join(", ", uniqueNumbers));*/


            /*Write a program and ask the user to supply a list of comma separated
            numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5
            numbers, display "Invalid List" and ask the user to re-try; otherwise,
            display the 3 smallest numbers in the list.*/

            /*while (true)
            {
                Console.WriteLine("Enter a list of comma-separated numbers (e.g., 5, 1, 9, 2, 10): ");
                string input = Console.ReadLine();

                var numbers = input.Split(',')
                                   .Select(n => n.Trim())
                                   .Where(n => int.TryParse(n, out _))
                                   .Select(int.Parse)
                                   .ToList();

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                }
                else
                {
                    var smallestNumbers = numbers.OrderBy(n => n).Take(3).ToList();
                    Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", smallestNumbers));
                    break;
                }
            }*/



            /*- Write a program and ask the user to enter a few numbers separated
            by a hyphen. Work out if the numbers are consecutive. For example, if
            the input is "5-6-7-8-9" or "20-19-18-17-16", display a message:
            "Consecutive"; otherwise, display "Not Consecutive".*/



            /* Console.WriteLine("Enter a few numbers separated by a hyphen (e.g., 5-6-7-8-9): ");
             string input = Console.ReadLine();

             ///This code will split the input string by hyphen, convert each part to an integer, and store them in a list.

             var numbers = input.Split('-')
                                .Select(n => int.Parse(n))
                                .ToList();

             bool isConsecutive = true;
             for (int i = 1; i < numbers.Count; i++)
             {
                 if (Math.Abs(numbers[i] - numbers[i - 1]) != 1)
                 {
                     isConsecutive = false;
                     break;
                 }
             }

             if (isConsecutive)
             {
                 Console.WriteLine("Consecutive");
             }
             else
             {
                 Console.WriteLine("Not Consecutive");
             }
            */


            /*Write a program and ask the user to enter their name. Use an array
            to reverse the name and then store the result in a new string. Display
            the reversed name on the console.*/

            /* Console.WriteLine("Enter your name: ");
             string name = Console.ReadLine();

             char[] nameArray = name.ToCharArray();

             Array.Reverse(nameArray);

             string reversedName = new string(nameArray);

             Console.WriteLine("Reversed name: " + reversedName);*/


            /*- Write a program and ask the user to enter 5 numbers. If a number
            has been previously entered, display an error message and ask the user
            to re-try. Once the user successfully enters 5 unique numbers, sort
            them and display the result on the console.*/

            /*List<int> numbers = new List<int>(); 

            while (numbers.Count < 5) // Loop until we have 5 unique numbers
            {
                Console.Write("Enter a unique number: "); // Prompt the user to enter a number
                int number;

                if (int.TryParse(Console.ReadLine(), out number)) 
                {
                    if (numbers.Contains(number)) // Check if the number has already been entered
                    {
                        Console.WriteLine("Error: This number has already been entered. Please enter a unique number.");
                    }
                    else
                    {
                        numbers.Add(number); 
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number."); 
                }
            }

            numbers.Sort(); 

            Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));*/


            /*Write a program and ask the user to continuously enter a number or
            type "Quit" to exit. The list of numbers may include duplicates. Display
            the unique numbers that the user has entered.*/

            /*HashSet<int> uniqueNumbers = new HashSet<int>();
            string input;

            while (true)
            {
                Console.Write("Enter a number (or type 'Quit' to exit): ");
                input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                int number;
                if (int.TryParse(input, out number))
                {
                    uniqueNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine("Unique numbers entered:");
            foreach (int num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }*/


            /*Write a program and ask the user to supply a list of comma separated
            numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5
            numbers, display "Invalid List" and ask the user to re-try; otherwise,
            display the 3 smallest numbers in the list.*/

            /*while (true)
            {
                Console.Write("Enter a list of comma-separated numbers (e.g., 5, 1, 9, 2, 10): ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid List. Please enter a list with at least 5 numbers.");
                    continue;
                }

                List<int> numbers = input.Split(',')
                                         .Select(n => int.TryParse(n, out int result) ? result : (int?)null)
                                         .Where(n => n.HasValue)
                                         .Select(n => n.Value)
                                         .ToList();

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List. Please enter a list with at least 5 numbers.");
                }
                else
                {
                    var smallestNumbers = numbers.OrderBy(n => n).Take(3).ToList();
                    Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", smallestNumbers));
                    break;
                }
            }*/


            //QUESTION 4

            /*Write a program and ask the user to enter a few numbers separated
            by a hyphen. Work out if the numbers are consecutive. For example, if
            the input is "5-6-7-8-9" or "20-19-18-17-16", display a message:
            "Consecutive"; otherwise, display "Not Consecutive".*/

            /*Console.Write("Enter a list of numbers separated by hyphens (e.g., 5-6-7-8-9): ");
            string input = Console.ReadLine();

            int[] numbers = input.Split('-').Select(n => int.Parse(n)).ToArray();

            bool isConsecutive = true;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i] - numbers[i - 1]) != 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }*/

            /*Write a program and ask the user to enter a few numbers separated
            by a hyphen. If the user simply presses Enter, without supplying an
            input, exit immediately; otherwise, check to see if there are duplicates.
            If so, display "Duplicate" on the console.*/

            /*Console.Write("Enter a list of numbers separated by hyphens (e.g., 5-3-2-5-8): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                return; // Exit immediately if the input is empty
            }

            string[] numberStrings = input.Split('-');
            List<int> numbers = new List<int>();
            HashSet<int> numberSet = new HashSet<int>();

            bool hasDuplicate = false;

            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString, out int number))
                {
                    if (!numberSet.Add(number))
                    {
                        hasDuplicate = true;
                        break;
                    }
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                    return;
                }
            }

            if (hasDuplicate)
            {
                Console.WriteLine("Duplicate");
            }
            else
            {
                Console.WriteLine("No duplicates found.");
            }*/

            /*- Write a program and ask the user to enter a time value in the 24-
            hour time format (e.g. 19:00). A valid time should be between 00:00
            and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid
            Time". If the user doesn't provide any values, consider it as invalid time.*/

            /*Console.Write("Enter a time value in the 24-hour format (e.g., 19:00): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            DateTime time;
            bool isValidTime = DateTime.TryParseExact(
                input,
                "HH:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out time
            );

            if (isValidTime)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }*/

            /*Write a program and ask the user to enter a few words separated by
            a space. Use the words to create a variable name with PascalCase. For
            example, if the user types: "number of students", display
            "NumberOfStudents". Make sure that the program is not dependent on
            the input. So, if the user types "NUMBER OF STUDENTS", the program
            should still display "NumberOfStudents".*/

            /*Console.Write("Enter a few words separated by space: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            // Split the input into words and convert each word to Title Case
            string[] words = input.ToLower().Split(' ')
                                 .Select(word => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(word))
                                 .ToArray();

            // Join the words to create a PascalCase variable name
            string variableName = string.Join("", words);

            Console.WriteLine("PascalCase Variable Name: " + variableName);*/

            /*Write a program and ask the user to enter an English word. Count the
            number of vowels (a, e, o, u, i) in the word. So, if the user enters
            "inadequate", the program should display 6 on the console.*/

            /*Console.Write("Enter an English word: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            int vowelCount = input.Count(c => "aeiou".Contains(char.ToLower(c)));

            Console.WriteLine($"The number of vowels in '{input}' is: {vowelCount}");*/

            
            //QUESTION 5
            
            /*Write a program that reads a text file and displays the number of
            words.*/












        }
    }
    }

