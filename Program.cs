using System;

namespace MyArrayApp
{
    class Program
    {
        static void Main1(string[] args)
        {
            //declaring array
            int[] numbers = new int[5];

            numbers[2] = 30;
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[3] = 40;
            numbers[4] = 50;

        
           // System.Console.WriteLine(numbers[3]);
        // System.Console.WriteLine(numbers[0]);

            int index = 0;

            while (index <=5)
            {
                System.Console.WriteLine(numbers[index]);

                index++;
            }
        
        }
    }
}
