using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Game
    {
        Table tab = new Table();


        public void SpinTheBallGame()
        {
            tab.Spin();
            Console.WriteLine($"The winning number is: {tab.ColorResult()} {tab.NumResult()}");
        }

        public void WinningBets()
        {
            
            if ( tab.NumResult() == 0 || tab.NumResult() == 00 )
            {
                Console.WriteLine($"Only {tab.ColorResult()} {tab.NumResult()} gets paid this time!");
            }
            else
            {
                NumberBet();
                EvenOddBet();
                RedBlackBet();
                HighLowBet();
                DozensBet();
                ColumumsBet();
            }
        }

        public void NumberBet()
        {
            Console.WriteLine($"Everyone who bet on {tab.NumResult()} wins.");
        }

        public void EvenOddBet()
        {
            if ( tab.NumResult() % 2 == 0 )
                Console.WriteLine($"Everyone who bet even wins.");
            if ( tab.NumResult() % 2 != 0 )
                Console.WriteLine("Everyone who bet odd wins.");
        }

        public void RedBlackBet()
        {
            Console.WriteLine($"Everyone who bet on {tab.ColorResult()} wins.");
        }

        public void HighLowBet()
        {
            if ( tab.NumResult() <= 18 )
                Console.WriteLine("Everyone who bet on \"1 to 18\" wins.");
            if ( tab.NumResult() > 18 )
                Console.WriteLine("Everyone who bet on \"19 to 36\" wins.");
        }

        public void DozensBet()
        {
            if ( tab.NumResult() < 13 )
                Console.WriteLine("Everyone who bet on \"1st 12\" wins.");
            if ( tab.NumResult() > 12 && tab.NumResult() < 25 )
                Console.WriteLine("Everyone who bet on \"2nd 12\" wins.");
            if ( tab.NumResult() > 24 )
                Console.WriteLine("Everyone who bet on \"3rd 12\" wins.");
        }

        public void ColumumsBet()
        {
            int n = tab.NumResult();
            if ( n == 3 || n == 6 || n == 9 || n == 12 || n == 15 || n == 18 || n == 21 || n == 24 || n == 27 || n == 30 || n == 33 || n == 36 )
                Console.WriteLine("Everyone who bet the top column wins.");
            if ( n == 2 || n == 5 || n == 8 || n == 11 || n == 14 || n == 17 || n == 20 || n == 23 || n == 26 || n == 29 || n == 32 || n == 35 )
                Console.WriteLine("Everyone who bet the middle column wins.");
            else
                Console.WriteLine("Everyone who bet the bottom column wins.");
        }
    }
}
