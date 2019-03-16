namespace DeckOfCards
{
    public class Card
    {
        public string FaceValue { get; set; }

        public string Suit { get; set; }

        public string GetFullName()
        {
            string fullName = $"{FaceValue} of {Suit}";
            // TODO: Return the full name of the card. Ex: 2 of Hearts
            return fullName;

            //return fullname = $"{FaceValue} of {Suit}";
        }
    }
}