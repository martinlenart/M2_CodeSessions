using System;

namespace StaticVsNonStatic
{
    public class Friend
    {
        public string Name;
        public int Age;

        public static int NrOfFriends = 0;
        public static int Oldest = int.MinValue;

        public Friend (string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine($"Executing contructor for {Name}");
            NrOfFriends++;

            if (Age > Oldest)
            {
                Oldest = Age;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {                       
            Friend friend1 = new Friend ("John", 30);
            Friend friend2 = new Friend ("Mary", 40);

            Console.WriteLine($"I have {Friend.NrOfFriends} friends");
            Console.WriteLine($"My oldest friend is {Friend.Oldest} years old.");

        }
    }
}
