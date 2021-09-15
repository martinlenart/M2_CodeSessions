using System;

namespace ArrayExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 18; i >= 15; i--)
            {
                if (i % 2 == 0)
                   Console.WriteLine(i);
            }
            Console.WriteLine();

            int[] intArray = { 8, 14, 25, -7, 10, 3, 45, 8 };
            int searchVal = -7;

            foreach (var item in intArray)
            {
                if (searchVal == item)
                {
                    Console.WriteLine($"{item} Found");
                    break;
                }
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                if (searchVal == intArray[i])
                {
                    Console.WriteLine($"{intArray[i]} Found");
                    break;
                }

            }

            int[,] intMatrix = { { 8, 14, 25, -7 }, { 10, 3, 45, 8 } };

            for (int r = 0; r < intMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < intMatrix.GetLength(1); c++)
                {
                    if (searchVal == intMatrix[r,c])
                    {
                        Console.WriteLine($"{intMatrix[r,c]} Found");
                        break;
                    }
                }
            }
        }
    }
}
