using System;

namespace ClassNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the firstnames of the students in the class?");
            string sInput = Console.ReadLine();

            string[] classMates = sInput.Split(',');

            Console.WriteLine("Give me a name?");
            string sSearch = Console.ReadLine();

            bool foundClassMate = FindName(classMates, sSearch);

            if (foundClassMate)
            {
                Console.WriteLine($"Yes, {sSearch} is a student in the class");
            }
            else
            {
                Console.WriteLine($"No, I could not find {sSearch}");
            }
        }

        static bool FindName(string[] classMates, string sSearch)
        {
            bool foundClassMate = false;
            foreach (var name in classMates)
            {
                if (sSearch.ToLower().Trim() == name.ToLower().Trim())
                {
                    foundClassMate = true;
                    break;
                }
            }

            return foundClassMate;
        }
    }
}
