using System;
using System.Collections.Generic;
namespace MyArrayApp
{
    class ListExercise3
    {
        static void Main(string[] args)
        {
            // Decalre a list of strings
            List<string> stringList = new List<string>();    

            // Ask the user to enter in a word
            System.Console.WriteLine("Please enter a word:");

            // Capture the word the user has entered.
            string inputFromUserAsString = System.Console.ReadLine(); 

            while ( inputFromUserAsString != "stop" ) {

                stringList.Add(inputFromUserAsString);

                System.Console.WriteLine("Please enter another word:");
                inputFromUserAsString = System.Console.ReadLine(); 
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("---- Stop ----");

            // Display each item in stringList
            foreach (string item in stringList) {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("---- List printed Backwards ----");

            // List the items going backwards
            for (int index = stringList.Count - 1; index >= 0; index--)
            {
                System.Console.WriteLine(stringList[index]);
            }   

        }
    }
}