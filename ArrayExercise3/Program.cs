using System;

namespace ArrayExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Hello", "my", "name", "is", "Martin" };

            string search = "Martin";
            bool found;

            FindString(stringArray, search, out found);

            if (found)
            {
                Console.WriteLine();
                Console.WriteLine($"{search} found");
            }


            Console.WriteLine();
        }

        private static void FindString(string[] stringArray, string search, out bool found)
        {
            found = false;
            foreach (var item in stringArray)
            {
                if (item == search)
                {
                    found = true;
                }

                if (item == "name" || item == "is")
                    continue;

                Console.Write($"{item} ");
            }

            Console.WriteLine();
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] == "name" || stringArray[i] == "is")
                    continue;

                Console.Write($"{stringArray[i]} ");

            }
        }
    }
}
