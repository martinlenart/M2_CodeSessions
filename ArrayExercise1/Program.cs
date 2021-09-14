using System;

namespace ArrayExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare as uninitialized
            decimal[] decimalArray = new decimal[5];

            //Initialize the array
            for (int i = 0; i < decimalArray.Length; i++)
            {
                decimalArray[i] = i * 2M;
            }

            //Printout the array
            foreach (var item in decimalArray)
            {
                Console.Write($"{item:N4}  ");
            }

            //Find the largest number in array
            Console.WriteLine();
            decimal myLargestValue = decimal.MinValue;
            foreach (var item in decimalArray)
            {
                if (item > myLargestValue)
                {
                    myLargestValue = item;
                }
            }
            Console.WriteLine(myLargestValue);
        }
    }
}
// Exercise:
// 1.   Create an array of decimal that is 10 elements in size. Initialize it using a for-loop were each element has value index*2
// 2a.  Iterate over the decimal array using a foreach-loop and find the largest number. Print it out.
