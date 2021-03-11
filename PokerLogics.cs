using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerApp
{
    class PokerLogics
    {
        public bool IsPair(Player _player)
        {
            
                return _player.hand.GroupBy(h => h.number)
                           .Where(g => g.Count() == 2)
                           .Count() == 1;
            
        }

        public bool IsTwoPair(Player _player)
        {
           
                return _player.hand.GroupBy(h => h.number)
                            .Where(g => g.Count() == 2)
                            .Count() == 2;
            
        }

        public bool IsThreeOfAKind(Player _player)
        {
            
                return _player.hand.GroupBy(h => h.number)
                            .Where(g => g.Count() == 3)
                            .Any();
            
        }

        public bool IsFourOfAKind(Player _player)
        {
           
                return _player.hand.GroupBy(h => h.number)
                            .Where(g => g.Count() == 4)
                            .Any();
            
        }

        public bool IsFlush(Player _player)
        {
            
                return _player.hand.GroupBy(h => h.suit).Count() == 1;
            
        }

        public bool IsFullHouse(Player _player)
        {

            return true;
        }

        public bool IsStraight(Player _player)
        {

            return true;
        }
    }
}
