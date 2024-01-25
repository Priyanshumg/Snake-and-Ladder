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
        private Random random = new Random();

        static int cases()
        {
            Random cases = new Random();
            return cases.Next(0, 4);
        }

        static int ladder()
        {
            Random ladder = new Random();
            return ladder.Next(1, 11);
        }

        static int snake()
        {
            Random snake = new Random();
            return snake.Next(1, 11);
        }

        static void Main(string[] args)
        {
            //int dice = rand();
            Program program = new Program();
            int Player1 = program.position;
            int count = 0;
            // UC3
            while (Player1 < 100)
            {
                int switch_case = cases();
                Random dice = new Random();
                int rolling_dice = dice.Next(1, 7);
                // Last was here 
                if (Player1!= 100 && Player1 <= 100){
                    Player1 += rolling_dice;
                    Console.WriteLine($"Player Position {Player1}");
                    Console.WriteLine("Rolling Dice");
                    Console.WriteLine($"Dice: {rolling_dice}");
                    Console.WriteLine($"Updated Position {Player1}");

                }
                Console.WriteLine();
                switch (switch_case)
                {
                    case 2:
                        {
                            // This is for ladder
                            if (Player1 >= 0 && Player1 <= 89)
                            {
                                int go_up_by = ladder();
                                Console.WriteLine($"You're reached Ladder, Going up by {go_up_by}");
                                Console.WriteLine();
                                Player1 += go_up_by;
                            }
                            break;
                        }
                    case 3:
                        {
                            // This case if for snake
                            if (Player1 > 10)
                            {
                                int go_down_by = snake();
                                Console.WriteLine($"You're reached Snake, Going down by {go_down_by}");
                                Console.WriteLine($"Player Position = {Player1}");
                                Console.WriteLine();
                                Player1 -= go_down_by;
                            }
                            break;
                        }
                        }
                count++;
                Console.WriteLine($"Total number of steps {count}");
                }
                Console.ReadLine();
            }
        }
    }

