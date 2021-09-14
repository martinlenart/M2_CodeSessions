using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nested while loops
            Console.WriteLine("Nested while-loops");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine();
                Console.WriteLine($"i: {i++}");

                int k = 0;
                while (k < 10)
                {
                    Console.WriteLine($"k: {k++}");
                }
            }


            //Nested for-loops
            Console.WriteLine();
            Console.WriteLine("Nested for-loops");
            for (int j = 10; j >= 0; j--)
            {
                Console.WriteLine($"i: {j}");
                for (int k = 1; k <= 10; k++)
                {
                    Console.WriteLine($"k: {k}");
                }
                Console.WriteLine();
            }
        }
    }
}
