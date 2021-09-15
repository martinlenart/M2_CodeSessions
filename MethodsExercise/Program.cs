using System;

namespace MethodsExercise
{
	public enum PlayingCardColor
	{
		Clubs, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                // Poker Value order
	}
	public struct PlayingCard
	{
		public PlayingCardColor Color;
		public PlayingCardValue Value;
	}
	class Program
    {
        static void Main(string[] args)
        {
			PlayingCard card1 = new PlayingCard 
			{ Color = PlayingCardColor.Clubs, Value = PlayingCardValue.Queen };
	
			PlayingCard card2 = new PlayingCard
			{ Color = PlayingCardColor.Clubs, Value = PlayingCardValue.Ace };

			string s1 = FaceOrValue(card1.Value);
			Console.WriteLine(s1);

			Console.WriteLine(HasSameColor(card1, card2)); // true or false

			bool same = HasSameColor(card1, card2, out _);

			string myColor;
			bool same1 = HasSameColor(card1, card2, out myColor);

			if (same1)
            {
				Console.WriteLine($"Both cards are of the same color which is {myColor}");
            }


		}

		static string FaceOrValue(PlayingCardValue pcValue)
        {
            if (pcValue == PlayingCardValue.Knight ||
				pcValue == PlayingCardValue.Queen ||
				pcValue == PlayingCardValue.King ||
				pcValue == PlayingCardValue.Ace)
            {
				return "Face";
            }
            else
            {
				return "Value";
            }
        }
		static string RedOrBlack(PlayingCardColor pcColor)
        {
			if (pcColor == PlayingCardColor.Clubs ||
				pcColor == PlayingCardColor.Spades)
				return "Black";

			return "Red";
        }

		static bool HasSameColor(PlayingCard card1, PlayingCard card2, out string color)
        {
			color = RedOrBlack(card1.Color);
			return card1.Color == card2.Color;
        }
		static bool HasSameColor (PlayingCard card1, PlayingCard card2) => card1.Color == card2.Color;
	}
}
