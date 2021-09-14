using System;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 5, 4, 3, 2, 1 };

            Console.WriteLine("With foreach-loop");
            int k = 0;
            foreach (int item in intArray)
            {
                Console.WriteLine(item);
                k++;
            }

            Console.WriteLine("With for-loop");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }


            bool[] boolArray = { true, true, false, false };
            foreach (var item in boolArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
