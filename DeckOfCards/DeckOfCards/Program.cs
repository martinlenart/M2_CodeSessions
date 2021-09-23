using System;

namespace DeckOfCards
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades			// Poker suit order, Spades highest
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

		string FaceOrValue()
		{
			string sRet;
			switch (Value)
			{
				case PlayingCardValue.Ace:
				case PlayingCardValue.Knight:
				case PlayingCardValue.Queen:
				case PlayingCardValue.King:
					sRet = "Face";
					break;

				default:
					sRet = "Value";
					break;
			}
			return sRet;
		}
		string BlackOrRed()
		{
			if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
				return "Black";

			return "Red";
		}
		public string PrintOut() => $"{Value} of {Color}, a {BlackOrRed()} {FaceOrValue()} card";

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

			PlayingCard[] deckOfCards = new PlayingCard[52];

			deckOfCards[0] = new PlayingCard { Value = PlayingCardValue.Two, Color = PlayingCardColor.Spades };
			deckOfCards[1] = new PlayingCard { Value = PlayingCardValue.Three, Color = PlayingCardColor.Spades };


			//You can loop in a for-loop using an enum.
			//Remember int is the underlying type of an enum
			int cardNr1 = 0;
			for (PlayingCardColor color = PlayingCardColor.Clubs; color <= PlayingCardColor.Spades; color++)
			{
				for (PlayingCardValue value = PlayingCardValue.Two; value <= PlayingCardValue.Ace; value++)
				{
					//Alternative way as long as PlayingCard is a struct
					deckOfCards[cardNr1].Color = color;
					deckOfCards[cardNr1].Value = value;

					//Alternative way working for PlayingCard being both class and struct
					deckOfCards[cardNr1] = new PlayingCard { Color = color, Value = value };

					//Prepare to initialize next card
					cardNr1++;
				}
			}

			//You can also use a foreach loop to initialize the deck of cards
			cardNr1 = 0;
			foreach (PlayingCardColor color in typeof(PlayingCardColor).GetEnumValues())
			{
				foreach (PlayingCardValue value in typeof(PlayingCardValue).GetEnumValues())
				{
					//Alternative way as long as PlayingCard is a struct
					deckOfCards[cardNr1].Color = color;
					deckOfCards[cardNr1].Value = value;

					//Alternative way working for PlayingCard being both class and struct
					deckOfCards[cardNr1] = new PlayingCard { Color = color, Value = value };

					//Prepare to initialize next card
					cardNr1++;
				}
			}


			Console.WriteLine("The complete deck");
            foreach (var item in deckOfCards)
            {
				Console.WriteLine(item.PrintOut());
            }

		}
	}
}
