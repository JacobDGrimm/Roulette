using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Table
    {
        // this array is all the numbers on a roulette wheel in numerical order
        int[] wheelNums = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
                                          10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
                                          20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
                                          30, 31, 32, 33, 34, 35, 36, 00  };

        // this array is the colors on the wheel and it matches the number array
        Colors[] wheelColors = new Colors[] { Colors.Green, Colors.Red, Colors.Black, Colors.Red, Colors.Black, Colors.Red,
                                                Colors.Black, Colors.Red, Colors.Black, Colors.Red, Colors.Black,
                                                Colors.Black, Colors.Red, Colors.Black, Colors.Red, Colors.Black,
                                                Colors.Red, Colors.Black, Colors.Red, Colors.Red, Colors.Black,
                                                Colors.Red, Colors.Black, Colors.Red, Colors.Black, Colors.Red,
                                                Colors.Black, Colors.Red, Colors.Black, Colors.Black, Colors.Red,
                                                Colors.Black, Colors.Red, Colors.Black, Colors.Red, Colors.Black,
                                                Colors.Red, Colors.Green };

    }
}
