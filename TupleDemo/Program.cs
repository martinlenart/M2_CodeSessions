using System;

namespace TupleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            long b = 3;
            float c = 3.2F;
            double d = 3.2;
            decimal e = 3.2M;
            string s = "hello";

            (int, float) t1 = (3, 3.2F);
            (int, float) t2 = (5, 7.5F);

            Console.WriteLine(t1);
            Console.WriteLine(t1 == t2); // false

            t1 = t2;
            Console.WriteLine(t1 == t2); // true

            Console.WriteLine(t1.Item1);  // 5
            Console.WriteLine(t1.Item2);  // 7.5

            (int myInt, float myFloat) t3 = (4, 8.3F);

            Console.WriteLine(t3.myInt);
            Console.WriteLine(t3.myFloat);

            Console.WriteLine((a, c) == (3, 3.2F)); //true

            int[] myArray = { 1, 2, 3, 4, 5 };

        }

    }
}
