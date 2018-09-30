﻿using System;
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


    }
}
