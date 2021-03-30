using System;
using System.Collections.Generic;

namespace Cards
{
    class Pack
    {
        public const int NumSuits = 4;
        public const int CardsPerSuit = 13;
        //private PlayingCard[,] cardPack;
        private Dictionary<Suit, List<PlayingCard>> cardPack;
        private Random randomCardSelector = new Random();

        public Pack()
        {
            //this.cardPack = new PlayingCard[NumSuits, CardsPerSuit];

            this.cardPack = new Dictionary<Suit, List<PlayingCard>>(NumSuits);
            //first ver
            //for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            //{
            //    for (Value value = Value.Two; value <= Value.Ace; value++)
            //    {                  
            //        cardPack[suit].Add(new PlayingCard(suit, value));
            //    }
            //}

            //Second ver
            //List<PlayingCard> cardsInSuit = new List<PlayingCard>(CardsPerSuit);
            //for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            //{
            //    for (Value value = Value.Two; value <= Value.Ace; value++)
            //    {
            //        cardsInSuit[(int)value] = new PlayingCard(suit, value);
            //    }

            //    cardPack[suit] = cardsInSuit;
            //    cardsInSuit.Clear();
            //}

            //like in book

            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                List<PlayingCard> cardsInSuit = new List<PlayingCard>(CardsPerSuit);
                for (Value value = Value.Two; value <= Value.Ace; value++)
                {
                    cardsInSuit.Add(new PlayingCard(suit, value));
                }
                this.cardPack.Add(suit, cardsInSuit);
            }
        }

        public PlayingCard DealCardFromPack()
        {
            Suit suit = (Suit)randomCardSelector.Next(NumSuits);

            while (this.IsSuitEmpty(suit))
            {
                suit = (Suit)randomCardSelector.Next(NumSuits);
            }

            Value value = (Value)randomCardSelector.Next(CardsPerSuit);
            while (this.IsCardAlreadyDealt(suit, value))
            {
                value = (Value)randomCardSelector.Next(CardsPerSuit);
            }
            //original
            //PlayingCard card = this.cardPack[suit, (int)value];            
            //this.cardPack[(int)suit, (int)value] = null;

            //ver 1
            //PlayingCard card = this.cardPack[suit][(int)value];
            PlayingCard card = this.cardPack[suit].Find(c => c.CardValue == value);
            cardPack[suit].Remove(card);
            return card;
        }

        private bool IsSuitEmpty(Suit suit)// => !cardPack.ContainsKey(suit);
        {
                bool result = true;
                for (Value value = Value.Two; value <= Value.Ace; value++)
                {
                    if (!IsCardAlreadyDealt(suit, value))
                    {
                        result = false;
                        break;
                    }                       
                }
                
                return result;
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)// => !this.cardPack[suit].Contains(new PlayingCard(suit, value));
        {
            return !this.cardPack[suit].Exists(c => c.CardValue == value);
        }
    }
}