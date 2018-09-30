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
                StreetBet();
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

        public void StreetBet()
        {
            int n = tab.NumResult();

            if ( n < 4 )
                Console.WriteLine("Everyone who bet the first street wins.");
            if ( n > 3 && n < 7 )
                Console.WriteLine("Everyone who bet the second street wins.");
            if ( n > 6 && n < 10 )
                Console.WriteLine("Everyone who bet the third street wins.");
            if ( n > 9 && n < 13 )
                Console.WriteLine("Everyone who bet the fourth street wins.");
            if ( n > 12 && n < 16 )
                Console.WriteLine("Everyone who bet the fifth street wins.");
            if ( n > 15 && n < 19 )
                Console.WriteLine("Everyone who bet the sixth street wins.");
            if ( n > 18 && n < 22 )
                Console.WriteLine("Everyone who bet the seventh street wins.");
            if ( n > 21 && n < 25 )
                Console.WriteLine("Everyone who bet the eighth street wins.");
            if ( n > 24 && n < 28 )
                Console.WriteLine("Everyone who bet the ninth street wins.");
            if ( n > 27 && n < 31)
                Console.WriteLine("Everyone who bet the tenth street wins.");
            if ( n > 30 && n < 34 )
                Console.WriteLine("Everyone who bet the eleventh street wins.");
            if ( n > 33 )
                Console.WriteLine("Everyone who bet the last street wins.");

        }
    }
}
