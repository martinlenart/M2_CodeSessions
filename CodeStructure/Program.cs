using System;

namespace CodeStructure
{
    //Here can I ONLY declare types
    //For example, enum ??, struct ??, class ?? record ??
    public struct Example1
    {
        int X, Y;
    }

    class Program
    {
        //Here I can declare types, members (data and function)
        public struct Example2
        {
            int X, Y;
        }
        int Member1 = 0;
        int Member2 = 0;

        bool IsEqual (int param1, int param2)
        {
            //Here I can declare variables and write code

            return param1 == param2;
        }


        static void Main(string[] args)
        {
            //Here I can declare variables and write code
            
            Console.WriteLine("Hello World!");
        }
    }
}
