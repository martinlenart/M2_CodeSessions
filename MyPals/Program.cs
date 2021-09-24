using System;

namespace MyPals
{
    public enum FriendLevel
    {
        Casual, Good, Super, Family
    }
    public struct Friend
    {
        public string FirstName;       //Both FirstName and LastName equals null means an empty space in myFriends
        public string LastName;
        public FriendLevel Level;
        public string PhoneNr;
        public DateTime BirthDate;
    }

    class Program
    {
        public const int MaxNrOfFriends = 30;
        static void Main(string[] args)
        {
            Friend[] myFriends = new Friend[MaxNrOfFriends];

            Console.WriteLine($"My list of friends has place for {MaxNrOfFriends} friends");
            Console.WriteLine($"I have right now {NrOfFriends(myFriends)} friends  :-(");

            myFriends[0] = new Friend { FirstName = "John", LastName = "Smith", BirthDate = DateTime.Parse("1964-03-25"), Level = FriendLevel.Super, PhoneNr = "+1 (312) 556 234" };
            Console.WriteLine($"I have right now {NrOfFriends(myFriends)} friend :-)");

        }

        public static int NrOfFriends (Friend[] Friends)
        {
            int nrOfFriends = 0;
            foreach (var item in Friends)
            {
                if (item.FirstName != null && item.LastName != null)
                    nrOfFriends++;
            }

            return nrOfFriends;
        }
    }
}
