using System;
using System.Collections;
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

        static int rand()
        {
            // UC 2
            Random random = new Random();
            return random.Next(0, 7);
        }

        static int cases()
        {
            Random cases = new Random();
            return cases.Next(0, 4);
        }


        static void Main(string[] args)
        {
            int dice = rand();
            Program program = new Program();
            int Player1 = program.position = 10;
            Console.WriteLine(Player1);
            int switch_case = cases();
            switch (switch_case)
            {
                case 1:
                {
                    Console.WriteLine("This is Case 1");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("This is Case 2");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("This is Case 3");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}