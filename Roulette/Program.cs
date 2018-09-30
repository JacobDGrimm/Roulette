using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    // enum for colors so that the colors have bounds and are easier to work with
    enum Colors { Black, Red, Green};

    class Program
    {
        

        static void Main(string[] args)
        {
            Table tab = new Table();

            tab.Spin();
        }
    }
}
