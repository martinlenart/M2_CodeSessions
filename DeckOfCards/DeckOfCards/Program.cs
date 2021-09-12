using System;

namespace DeckOfCards
{
	public enum PlayingCardColor
	{
		Clubs, Diamonds, Hearts, Spades			// Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace				// Poker Value order
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
			PlayingCard card1 = new PlayingCard { Value = PlayingCardValue.Ace, Color = PlayingCardColor.Spades };
			PlayingCard card2 = new PlayingCard { Value = PlayingCardValue.Ace, Color = PlayingCardColor.Hearts };
			PlayingCard card3 = new PlayingCard { Value = PlayingCardValue.Ace, Color = PlayingCardColor.Clubs };
			PlayingCard card4 = new PlayingCard { Value = PlayingCardValue.Ace, Color = PlayingCardColor.Diamonds };

			Console.WriteLine($"card1 is an {card1.Value} of {card1.Color}");
			Console.WriteLine($"card2 is an {card2.Value} of {card2.Color}");
			Console.WriteLine($"card3 is an {card3.Value} of {card3.Color}");
			Console.WriteLine($"card4 is an {card4.Value} of {card4.Color}");
		}
	}
}
