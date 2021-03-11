using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PokerApp
{
    public enum Combination
    {
        None,
        Pair,
        TwoPair,
        ThreeofaKind,
        Straight,
        Flush,
        FullHouse,
        FourofaKind,
        StraightFlush,
        RoyalFlush,
    }
    public enum Suit
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds,
    }
    public enum Number : int
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    public class Card
    {
        public Suit suit;
        public Number number;
        public Card(Suit s, Number n)
        {
            suit = s;
            number = n;
        }
    }
}
