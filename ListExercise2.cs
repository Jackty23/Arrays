using System;
using System.Collections.Generic;
namespace MyArrayApp
{
    class ListExercise2
    {
        static void Main5(string[] args)
        {
            int number1 = Convert.ToInt32(args[0]);
            int number2 = Convert.ToInt32(args[1]);
            int number3 = Convert.ToInt32(args[2]);
            int number4 = Convert.ToInt32(args[3]);
            int number5 = Convert.ToInt32(args[4]);

            List<int> integerList = new List<int>();
            integerList.Add(number1);
            integerList.Add(number2);
            integerList.Add(number3);
            integerList.Add(number4);
            integerList.Add(number5);

            System.Console.WriteLine("Number of items in the list: " + integerList.Count );

            // ask the user for another number
            System.Console.WriteLine("Please enter another number: ");

            // capture the number from the user as a String
            string inputFromUserAsString = System.Console.ReadLine();

            // convert the string to an Integer
            int userInputAsInt = Convert.ToInt32(inputFromUserAsString);

            // Check if this integer exists in the list.
            if (integerList.Contains(userInputAsInt)) {
                System.Console.WriteLine("The number you entered exists in the list.");
            }
            else
            {
                System.Console.WriteLine("The number you entered does NOT exist in the list.");
            }


            // Find out how many times the final number is repeated in the list.
            int repeatCounter = 0;

            foreach (int item in integerList) {
                if (userInputAsInt == item) {
                    repeatCounter++;
                }
            }

            System.Console.WriteLine( inputFromUserAsString + " is repeated in the list " + repeatCounter + " times");

        }
    }
}