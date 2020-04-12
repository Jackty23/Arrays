using System;

namespace MyArrayApp
{
    class ArrayExercise1
    {
        static void Main2(string[] args)
        {

            

            //System.Console.WriteLine("Hello " + args[0]);
            //System.Console.WriteLine("Hello " + args[1]);
            //System.Console.WriteLine("Hello " + args[2]);
            //System.Console.WriteLine("Hello " + args[3]);
            //System.Console.WriteLine("Hello " + args[4]);
            //System.Console.WriteLine("asdf")

            int index = 0;

            while (index <=4)
            {
                //Looping through an array using a while loop
                System.Console.WriteLine("Hello " + args[index]);
                index++;
            }
        
        }
    }
}
