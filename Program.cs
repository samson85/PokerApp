using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerApp
{
    class Program
    {
        public IEnumerable<Player> Cards { get; set; }
        static void Main(string[] args)
        {
            Console.Title = "Poker";
             
        Player PlayerOne = new Player();
            Player PlayerTwo = new Player();
            Player PlayerThree = new Player();
            Player PlayerFour = new Player();
            PlayerOne.GenerateHand();
            PlayerTwo.GenerateHand();
            PlayerThree.GenerateHand();
            PlayerFour.GenerateHand();
            bool quit = false;
            Console.WriteLine("Welcome to Poker!");
            Console.WriteLine("Want to play?");
            string userinput = Console.ReadLine();
            if (userinput == "no" || userinput == "n") quit = true;
            while (!quit)
            {
                Console.WriteLine("Your cards are:\n");
                Console.Write("\n");
                Console.Write("\n");
                Console.Write("Player 1 :");
                Console.Write("\n");
                for (int a = 0; a < 5; a++)
                {
                    Console.Write(PlayerOne.hand[a].number.ToString());
                    Console.Write(" of ");
                    Console.Write(PlayerOne.hand[a].suit.ToString());
                    Console.Write("\n");
                    

                }

                

                Console.Write("\n");
                Console.Write("Player 2 :");
                Console.Write("\n");
                for (int b = 0; b < 5; b++)
                {
                    
                    Console.Write(PlayerTwo.hand[b].number.ToString());
                    Console.Write(" of ");
                    Console.Write(PlayerTwo.hand[b].suit.ToString());
                    Console.Write("\n");
                   
                }
                Console.Write("\n");
                Console.Write("Player 3 :");
                Console.Write("\n");
                for (int c = 0; c < 5; c++)
                {
                    
                    Console.Write(PlayerThree.hand[c].number.ToString());
                    Console.Write(" of ");
                    Console.Write(PlayerThree.hand[c].suit.ToString());
                    Console.Write("\n");
                    
                }
                Console.Write("\n");
                Console.Write("Player 4 :");
                Console.Write("\n");
                for (int d = 0; d < 5; d++)
                {
                    
                    Console.Write(PlayerFour.hand[d].number.ToString());
                    Console.Write(" of ");
                    Console.Write(PlayerFour.hand[d].suit.ToString());
                    Console.Write("\n");
                    
                }

                quit = true;
            }


        }
    }
}
