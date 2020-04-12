using System;

namespace MyArrayApp
{
    class ArrayExercise2
    {
        static void Main3(string[] args)
        {
            //declaring array
            int[] numbersArray = new int[10];

           
            numbersArray[0] = 34;
            numbersArray[1] = 5;
            numbersArray[2] = 67;
            numbersArray[3] = 1;
            numbersArray[4] = 99;
            numbersArray[5] = 34;
            numbersArray[6] = 44;
            numbersArray[7] = 78;
            numbersArray[8] = 34;
            numbersArray[9] = 0;

            int result= 0;
            //result+=numbersArray[0];
            //result+=numbersArray[1];
            //result+=numbersArray[2];
            //result+=numbersArray[3];
            //result+=numbersArray[4];
            //result+=numbersArray[5];
            //result+=numbersArray[6];
            //result+=numbersArray[7];
            //result+=numbersArray[8];
            //result+=numbersArray[9];
            
            //System.Console.WriteLine(result);

            int index = 0;

            while(index <=9)
            {
                result+=numbersArray[index];
                index++;
            }

            System.Console.WriteLine(result);
        }
        

    }
}