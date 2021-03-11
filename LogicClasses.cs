using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PokerApp
{

    
    public class Player
    {
        Deck PlayerDeck = new Deck();
        public List<Card> hand = new List<Card>();

        public void GenerateHand()
        {
            for (int i = 0; i < 5; i++)
            {
                Card c = PlayerDeck.RandomCard();
                hand.Add(c);
                PlayerDeck.deck.Remove(c);
            }
        }
        public Combination CardCombo(Combination cardcombo)
        {
            cardcombo = Combination.None;
            return cardcombo;
        }
        public Card HighCard() // If combination = none, highest card is calculated
        {
            return null;
        }
    }
    class Deck
    {
        private Random rand = new Random();
        public List<Card> deck = new List<Card>();
        public Deck()
        {
            Card AofS = new Card(Suit.Spades, Number.Ace);
            deck.Add(AofS);
            Card TwoofS = new Card(Suit.Spades, Number.Two);
            deck.Add(TwoofS);
            Card ThreeofS = new Card(Suit.Spades, Number.Three);
            deck.Add(ThreeofS);
            Card FourofS = new Card(Suit.Spades, Number.Four);
            deck.Add(FourofS);
            Card FiveofS = new Card(Suit.Spades, Number.Five);
            deck.Add(FiveofS);
            Card SixofS = new Card(Suit.Spades, Number.Six);
            deck.Add(SixofS);
            Card SevenofS = new Card(Suit.Spades, Number.Seven);
            deck.Add(SevenofS);
            Card EightofS = new Card(Suit.Spades, Number.Eight);
            deck.Add(EightofS);
            Card NineofS = new Card(Suit.Spades, Number.Nine);
            deck.Add(NineofS);
            Card TenofS = new Card(Suit.Spades, Number.Ten);
            deck.Add(TenofS);
            Card JackofS = new Card(Suit.Spades, Number.Jack);
            deck.Add(JackofS);
            Card QueenofS = new Card(Suit.Spades, Number.Queen);
            deck.Add(QueenofS);
            Card KingofS = new Card(Suit.Spades, Number.King);
            deck.Add(KingofS);
            Card AofH = new Card(Suit.Hearts, Number.Ace);
            deck.Add(AofH);
            Card TwoofH = new Card(Suit.Hearts, Number.Two);
            deck.Add(TwoofH);
            Card ThreeofH = new Card(Suit.Hearts, Number.Three);
            deck.Add(ThreeofH);
            Card FourofH = new Card(Suit.Hearts, Number.Four);
            deck.Add(FourofH);
            Card FiveofH = new Card(Suit.Hearts, Number.Five);
            deck.Add(FiveofH);
            Card SixofH = new Card(Suit.Hearts, Number.Six);
            deck.Add(SixofH);
            Card SevenofH = new Card(Suit.Hearts, Number.Seven);
            deck.Add(SevenofH);
            Card EightofH = new Card(Suit.Hearts, Number.Eight);
            deck.Add(EightofH);
            Card NineofH = new Card(Suit.Hearts, Number.Nine);
            deck.Add(NineofH);
            Card TenofH = new Card(Suit.Hearts, Number.Ten);
            deck.Add(TenofH);
            Card JackofH = new Card(Suit.Hearts, Number.Jack);
            deck.Add(JackofH);
            Card QueenofH = new Card(Suit.Hearts, Number.Queen);
            deck.Add(QueenofH);
            Card KingofH = new Card(Suit.Hearts, Number.King);
            deck.Add(KingofH);
            Card AofC = new Card(Suit.Clubs, Number.Ace);
            deck.Add(AofC);
            Card TwoofC = new Card(Suit.Clubs, Number.Two);
            deck.Add(TwoofC);
            Card ThreeofC = new Card(Suit.Clubs, Number.Three);
            deck.Add(ThreeofC);
            Card FourofC = new Card(Suit.Clubs, Number.Four);
            deck.Add(FourofC);
            Card FiveofC = new Card(Suit.Clubs, Number.Five);
            deck.Add(FiveofC);
            Card SixofC = new Card(Suit.Clubs, Number.Six);
            deck.Add(SixofC);
            Card SevenofC = new Card(Suit.Clubs, Number.Seven);
            deck.Add(SevenofC);
            Card EightofC = new Card(Suit.Clubs, Number.Eight);
            deck.Add(EightofC);
            Card NineofC = new Card(Suit.Clubs, Number.Nine);
            deck.Add(NineofC);
            Card TenofC = new Card(Suit.Clubs, Number.Ten);
            deck.Add(TenofC);
            Card JackofC = new Card(Suit.Clubs, Number.Jack);
            deck.Add(JackofC);
            Card QueenofC = new Card(Suit.Clubs, Number.Queen);
            deck.Add(QueenofC);
            Card KingofC = new Card(Suit.Clubs, Number.King);
            deck.Add(KingofC);
            Card AofD = new Card(Suit.Diamonds, Number.Ace);
            deck.Add(AofD);
            Card TwoofD = new Card(Suit.Diamonds, Number.Two);
            deck.Add(TwoofD);
            Card ThreeofD = new Card(Suit.Diamonds, Number.Three);
            deck.Add(ThreeofD);
            Card FourofD = new Card(Suit.Diamonds, Number.Four);
            deck.Add(FourofD);
            Card FiveofD = new Card(Suit.Diamonds, Number.Five);
            deck.Add(FiveofD);
            Card SixofD = new Card(Suit.Diamonds, Number.Six);
            deck.Add(SixofD);
            Card SevenofD = new Card(Suit.Diamonds, Number.Seven);
            deck.Add(SevenofD);
            Card EightofD = new Card(Suit.Diamonds, Number.Eight);
            deck.Add(EightofD);
            Card NineofD = new Card(Suit.Diamonds, Number.Nine);
            deck.Add(NineofD);
            Card TenofD = new Card(Suit.Diamonds, Number.Ten);
            deck.Add(TenofD);
            Card JackofD = new Card(Suit.Diamonds, Number.Jack);
            deck.Add(JackofD);
            Card QueenofD = new Card(Suit.Diamonds, Number.Queen);
            deck.Add(QueenofD);
            Card KingofD = new Card(Suit.Diamonds, Number.King);
            deck.Add(KingofD);
        }
        private void Shuffle()
        {
            Random rand = new Random();
            int y = 0;
            foreach (Card c in deck)
            {
                y++;
            }
            for (int i = 0; i < 100; i++)
            {
                int x = rand.Next(0, y);
                Card c = deck[x];
                deck.Remove(c);
                deck.Add(c);
            }
        }
        public Card RandomCard()
        {
            Shuffle();
            Random rand = new Random();
            int y = 0;
            foreach (Card c in deck)
            {
                y++;
            }
            int x = rand.Next(0, y);
            return deck[x];
        }
        public Player DetermineWinner(Player One, Player Two, Player Three, Player Four)
        {
            return null;
        }


    }
}
