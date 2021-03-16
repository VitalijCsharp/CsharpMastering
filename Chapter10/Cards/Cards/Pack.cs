using System;

namespace Cards
{	
	class Pack
	{
        public const int NumSuits = 4;
        public const int CardsPerSuit = 13;
        private PlayingCard[,] cardPack;
        private Random randomCardSelector = new Random();

        public Pack()
        {
            this.cardPack = new PlayingCard[4, 13];
            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                for (Value value = Value.Two; value <= Value.Ace; value++)
                {
                    cardPack[(int)suit, (int)value] = new PlayingCard(suit, value);
                }
            }
        }

        public PlayingCard DealCardFromPack()
        {
            // TODO: pick a random card, remove it from the pack, and return it
            Suit suit = (Suit)randomCardSelector.Next(NumSuits);
            while (this.IsSuitEmpty(suit))
            {
                suit = (Suit)randomCardSelector.Next(NumSuits);
            }
            Value value = (Value)randomCardSelector.Next(CardsPerSuit);
            while(IsCardAlreadyDealt(suit, value))
            {
                value = (Value)randomCardSelector.Next(CardsPerSuit);
            }
            PlayingCard card = cardPack[(int)suit, (int)value];
            cardPack[(int)suit, (int)value] = null;

            return card;
        }

        private bool IsSuitEmpty(Suit suit)
        {
            // TODO: return true if there are no more cards available in this suit
            for (Value value = Value.Two; value <= Value.Ace; value++)
            {
                //bool result = true;
                if (!IsCardAlreadyDealt(suit, value)/*cardPack[(int)suit, (int)value] != null*/)
                {   
                    //result = false;
                    //break;
                    return false;
                }
            }
            //return result;
            return true;
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value) => cardPack[(int)suit, (int)value] == null;
       
    }
}