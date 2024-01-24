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
        private int position = 0;
        static void Main(string[] args)
        {
            Program program = new Program();
            int Player1 = program.position = 10;
            Console.WriteLine(Player1);
        }
    }
}
