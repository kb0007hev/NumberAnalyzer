using System;

namespace NUMBER_ANALYZER
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string userName;
            int userInput;
            string userResponse = "Yes";

            while (userResponse == "Yes")
            {
                Console.WriteLine("What is your first name?");
                userName = Console.ReadLine();

                Console.WriteLine("Please enter a whole number: ");
                string userInputString = Console.ReadLine();

                bool validInput = int.TryParse(userInputString, out userInput);

                while (!validInput || userInput < 0 || userInput > 100)
                {
                    Console.WriteLine("Please enter a valid number between 0 and 100");
                    userInputString = Console.ReadLine();
                    validInput = int.TryParse(userInputString, out userInput);
                }

                if (userInput % 2 == 1 && userInput < 60)
                {
                    Console.WriteLine($"A - Hello {userName}, Your number is: {userInput}. It is odd and less than 60");
                }
                else if (userInput % 2 == 0 && userInput >= 2 && userInput <= 24)
                {
                    Console.WriteLine($"B - Hello {userName}, You entered an even number between 2 and 24 (inclusive)");
                }
                else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                {
                    Console.WriteLine($"C - Hello {userName}, You entered an even number between 26 and 60 (inclusive)");
                }
                else if (userInput % 2 == 0 && userInput > 60)
                {
                    Console.WriteLine($"D - Hello {userName}, You entered an even number greater than 60");
                }
                else if (userInput % 2 == 1 && userInput > 60)
                {
                    Console.WriteLine($"E - Hello {userName}, You entered {userInput}, which is an odd number greater than 60");
                }

                Console.WriteLine("Do you want to continue? (Yes or No)");
                userResponse = Console.ReadLine();
            }
        }
    }
}