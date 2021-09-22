using System;

namespace AppleDemo
{
    class Program
    {
        //Taste, Size, Color
        public enum AppleTaste
        {
            Sour, Sweet, Bitter
        }
        public enum AppleSize
        {
            Small, Normal, Large
        }
        public enum AppleColor
        {
            Red, Pink, Green, Yellow
            }
        public class Apple
        {
            //Taste, Size, Color
            public AppleTaste Taste;
            public AppleSize Size;
            public AppleColor Color;
            
            public static int AppleCount = 0;

            public bool IsEqual(Apple a2)
            {
                return Apple.IsEqual(this, a2);
            }

            public static bool IsEqual (Apple a1, Apple a2)
            {
 //               bool bEq = a1.Taste == a2.Taste && a1.Color == a2.Color && a1.Size == a2.Size;
 //               return bEq;

                return (a1.Taste, a1.Size, a1.Color) == (a2.Taste, a2.Size, a2.Color);
            }
            public Apple ()
            {
                AppleCount++;
            }
        }
        static void Main(string[] args)
        {
            Apple apple1 = new Apple
            {
                Taste = AppleTaste.Sour,
                Color = AppleColor.Green,
                Size = AppleSize.Large
            };

            Apple apple2 = new Apple
            {
                Taste = AppleTaste.Sweet,
                Color = AppleColor.Red,
                Size = AppleSize.Small
            };

            apple1.Color = AppleColor.Yellow;
            apple2.Size = AppleSize.Large;

            Console.WriteLine($"apple1 is {apple1.Taste} and {apple1.Color}");
            Console.WriteLine($"apple2 is {apple2.Taste} and {apple2.Size}");

            Console.WriteLine(apple1.Taste == AppleTaste.Sweet || apple1.Color == AppleColor.Yellow);
            Console.WriteLine(apple2.Taste == AppleTaste.Sweet || apple2.Color == AppleColor.Yellow);

            Console.WriteLine($"You have created {Apple.AppleCount} apples");

            Console.WriteLine(Apple.IsEqual(apple1, apple2));

        }
    }
}
