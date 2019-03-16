using System;

namespace DeckOfCards
{
    public class Deck
    {
        private Random random;
        private string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
        private string[] faceValues = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public Deck()
        {
            random = new Random();
            Cards = new Card[52];
            // TODO: Load the card deck with a standard deck of 52 cards.  Use loops, do not hard code each one.
            for (int i = 0; i < Cards.Length; i++)
            {
                Cards[i] = new Card();
            }
            int cardCount = 0;
            for (int i = 0; i < 4; i++)
            {
                //assign suit
                for (int j = 0; j < 13; j++)
                {
                    Card card = Cards[cardCount];
                    card.Suit = suits[i];
                    card.FaceValue = faceValues[j];
                    cardCount++;
                }

            }
            


        }

        public Card[] Cards { get; set; }

        public Card Draw()
        {
            // TODO: Return a random card from the deck.
            int randomIndex = random.Next(0, 20);
            Card card = Cards[randomIndex];

            return card;
        }
    }
}