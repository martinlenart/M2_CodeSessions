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
        public struct Apple
        {
            //Taste, Size, Color
            public AppleTaste Taste;
            public AppleSize Size;
            public AppleColor Color;
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

            bool myKind1 = apple1.Taste == AppleTaste.Sweet || apple1.Color == AppleColor.Yellow;
            bool myKind2 = apple2.Taste == AppleTaste.Sweet || apple2.Color == AppleColor.Yellow;



        }
    }
}
