using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    internal class Program
    {
        // UC 1
        private int position = 0;

        static int dice()
        {
            // UC 2
            Random random = new Random();
            return random.Next(0, 7);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int Player1 = program.position = 10;
            Console.WriteLine(Player1);
            Console.Write("Rolling Dice ... ");
            Console.WriteLine(dice());
            Console.ReadLine();
        }
    }
}
