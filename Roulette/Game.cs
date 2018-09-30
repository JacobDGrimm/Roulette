using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Game
    {
        public void SpinTheBallGame()
        {
            Table tab = new Table();

            tab.Spin();
            Console.WriteLine($"The winning number is: {tab.ColorResult()} {tab.NumResult()}");
        }

        public void WinningBets()
        {

        }
    }
}
