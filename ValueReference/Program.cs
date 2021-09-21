using System;

namespace ValueReference
{
    struct structPoint
    {
        public int X, Y;
    }
    class classPoint
    {
        public int X, Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            structPoint[] structPointArray = 
            { 
                new structPoint { X = 5, Y = 7 }, new structPoint { X = 5, Y = 7 }, new structPoint { X = 5, Y = 7 },
                new structPoint { X = 5, Y = 7 },new structPoint { X = 5, Y = 7 } 
            } ;

            Console.WriteLine(intArray == null);
            Console.WriteLine(structPointArray == null);

            Console.WriteLine();
            Console.WriteLine(intArray[0]);
            Console.WriteLine(structPointArray[0].X);
            Console.WriteLine(intArray[4]);
            Console.WriteLine(structPointArray[4].Y);

            classPoint[] classPointArray = new classPoint[5];

            Console.WriteLine();
            Console.WriteLine(classPointArray == null);

            classPointArray[0] = new classPoint();
            classPointArray[4] = new classPoint();

            Console.WriteLine();
            Console.WriteLine(classPointArray[0] == null); //false
            Console.WriteLine(classPointArray[2] == null); //true
            Console.WriteLine(classPointArray[4] == null); //false

            Console.WriteLine(classPointArray[4]?.X);
            Console.WriteLine(classPointArray[2]?.X);

        }
    }
}
