using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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

        static int ladder()
        {
            Random ladder = new Random();
            return ladder.Next(1,11);
        }

        static int snake()
        {
            Random snake = new Random();
            return snake.Next(1,11);
        }

        static void Main(string[] args)
        {
            int dice = rand();
            Program program = new Program();
            int Player1 = program.position;
            // UC3
            while (Player1 != 100)
            {
                Console.WriteLine($"Current Player Position {Player1}");
                
                int switch_case = cases();
                int go_up_by = ladder();
                int go_down_by = snake();
                if (Player1 == 100)
                {
                    Console.WriteLine("User Won!");
                }

                switch (switch_case)
                {
                    case 1:
                        {
                            // This is for no option case
                            Console.WriteLine("no play position");
                            break;
                        }
                    case 2:
                        {
                            // This is for ladder
                            // Console.WriteLine("This is Case 2");
                            Console.WriteLine($"Going up by {go_up_by}");
                            Player1 += go_up_by;
                            if (Player1 >= 95 && Player1 <= 100)
                            {
                                Console.WriteLine("Player stopped at position 97. Waiting for a 3 on the next roll.");
                                // Wait until the next dice roll is 
                                while (rand() < 1 || rand() >= 6) ; 
                            } 
                            break;
                        }
                    case 3:
                        {
                            // This case if for snake
                            // Console.WriteLine("This is Case 3");
                            Console.WriteLine($"Going down by {go_down_by}");
                            Player1 -= go_down_by;
                            if (Player1 < 0)
                            {
                                Player1 = 0;
                            }
                            break;
                        }
                }

            }
            
            Console.WriteLine($"Player Position = {Player1}");
            Console.ReadLine();
        }
    }
}