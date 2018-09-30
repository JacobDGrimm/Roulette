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

        
        int[] topC = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
        int[] midC = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        int[] botC = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

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
                DoubleSixBet();
                SplitBet();
                CornerBet();
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

        public void DoubleSixBet()
        {
            int[] fir = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] sec = new int[] { 7, 8, 9, 10, 11, 12 };
            int[] thi = new int[] { 13, 14, 15, 16, 17, 18 };
            int[] fou = new int[] { 19, 20, 21, 22, 23, 24 };
            int[] fiv = new int[] { 25, 26, 27, 28, 29, 30 };
            int[] six = new int[] { 31, 32, 33, 34, 35, 36 };
            int n = tab.NumResult();

            foreach (var item in fir)
            {
                if (item == n)
                    Console.WriteLine("Everyone who bet the first double row wins.");
            }
            foreach (var item in sec)
            {
                if ( item == n)
                    Console.WriteLine("Everyone who bet the second double row wins.");
            }
            foreach (var item in thi)
            {
                if ( item == n )
                    Console.WriteLine("Everyone who bet the third double row wins.");
            }
            foreach (var item in fou)
            {
                if (item == n)
                    Console.WriteLine("Everyone who bet the fourth double row wins.");
            }
            foreach (var item in fiv)
            {
                if (item == n)
                    Console.WriteLine("Everyone who bet the fifth double row wins.");
            }
            foreach (var item in six)
            {
                if (item == n)
                    Console.WriteLine("Everyone who bet the last double row wins.");
            }
        }

        public void SplitBet()
        {
            int n = tab.NumResult();
            Console.Write("Everyone on the ");
            for (int i = 0; i < topC.Length; i++)
            {
                if (n == topC[i] && i != 0 && i != 11)
                {
                    Console.Write($"{topC[i - 1]}/{topC[i]}, {topC[i + 1]}/{topC[i]}, ");
                }
                if (n == topC[i] && i == 0)
                {
                    Console.Write($"{topC[i + 1]}/{topC[i]}, ");
                }
                if (n == topC[i] && i == 11)
                {
                    Console.Write($"{topC[i - 1]}/{topC[i]}, ");
                }
                if ( n == topC[i] )
                {
                    Console.Write($"{topC[i]}/{midC[i]} ");
                }
            }
            for (int i = 0; i < midC.Length; i++)
            {
                if (n == midC[i] && i != 0 && i != 11)
                    Console.Write($"{midC[i - 1]}/{midC[i]}, {midC[i + 1]}/{midC[i]}, ");
                if (n == midC[i] && i == 0)
                    Console.Write($"{midC[i + 1]}/{midC[i]}, ");
                if (n == midC[i] && i == 11)
                    Console.Write($"{midC[i - 1]}/{midC[i]}, ");
                if (n == midC[i])
                    Console.Write($"{midC[i]}/{topC[i]}, {midC[i]}/{botC[i]} ");
            }
            for (int i = 0; i < botC.Length; i++)
            {
                if (n == botC[i] && i != 0 && i != 11)
                    Console.Write($"{botC[i - 1]}/{botC[i]}, {botC[i + 1]}/{botC[i]}, ");
                if (n == botC[i] && i == 0)
                    Console.Write($"{botC[i + 1]}/{botC[i]}, ");
                if (n == botC[i] && i == 11)
                    Console.Write($"{botC[i - 1]}/{botC[i]}, ");
                if (n == botC[i])
                    Console.Write($"{botC[i]}/{midC[i]} ");
            }
            Console.WriteLine("splits wins.");
        }

        public void CornerBet()
        {
            int n = tab.NumResult();
            Console.Write("Everyone on the ");
            for (int i = 0; i < topC.Length; i++)
            {
                if (n == topC[i] && i != 0 && i != 11)
                    Console.Write($"{topC[i]}/{topC[i-1]}/{midC[i]}/{midC[i-1]}, {topC[i]}/{topC[i+1]}/{midC[i]}/{midC[i+1]} ");
                if (n== topC[i] && i == 0)
                    Console.Write($"{topC[i]}/{topC[i+1]}/{midC[i]}/{midC[i+1]} ");
                if ( n == topC[i] && i == 11 )
                    Console.Write($"{topC[i]}/{topC[i-1]}/{midC[i]}/{midC[i-1]} ");
            }
            for (int i = 0; i < midC.Length; i++)
            {
                if (n == midC[i] && i != 0 && i != 11)
                    Console.Write($"{midC[i]}/{midC[i - 1]}/{topC[i]}/{topC[i - 1]}, {midC[i]}/{midC[i + 1]}/{topC[i]}/{topC[i + 1]}, {midC[i]}/{midC[i-1]}/{botC[i]}/{botC[i-1]}, {midC[i]}/{midC[i+1]}/{botC[i]}/{botC[i+1]} ");
                if (n == midC[i] && i == 0)
                    Console.Write($"{midC[i]}/{midC[i + 1]}/{topC[i]}/{topC[i + 1]}, {midC[i]}/{midC[i+1]}/{botC[i]}/{botC[i+1]} ");
                if (n == midC[i] && i == 11)
                    Console.Write($"{midC[i]}/{midC[i - 1]}/{topC[i]}/{topC[i - 1]}, {midC[i]}/{midC[i-1]}/{botC[i]}/{botC[i-1]} ");
            }
            for (int i = 0; i < botC.Length; i++)
            {
                if (n == botC[i] && i != 0 && i != 11)
                    Console.Write($"{botC[i]}/{botC[i - 1]}/{midC[i]}/{midC[i - 1]}, {botC[i]}/{botC[i + 1]}/{midC[i]}/{midC[i + 1]} ");
                if (n == botC[i] && i == 0)
                    Console.Write($"{botC[i]}/{botC[i + 1]}/{midC[i]}/{midC[i + 1]} ");
                if (n == botC[i] && i == 11)
                    Console.Write($"{botC[i]}/{botC[i - 1]}/{midC[i]}/{midC[i - 1]} ");
            }
            Console.WriteLine("corners wins.");
        }
    }
}
