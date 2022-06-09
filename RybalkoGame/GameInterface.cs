using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoGame
{
    internal class GameInterface
    {
        public void DrawMainMenu(int _m, int _pl)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t\t СIРНИКИ ВIД ВЛАДИСЛАВА!!!");
            Console.WriteLine("\n");
            Console.WriteLine("1) Play");
            Console.WriteLine($"2) Matches count > {_m}");
            Console.WriteLine($"3) {((_pl == 0) ? "Player vs Computer" : "Player vs Player")}");
            Console.WriteLine("4) Exit\n");
        }
        public void DrawGameInterface(int m)
        {
            Console.WriteLine("\n\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < m; j++)
                {
                    if (i == 0)
                    {
                        Console.Write("  @");
                    }
                    else
                    {
                        Console.Write("  |");
                    }
                }
            }
            Console.WriteLine("\n\n");
        }
        public int InputMatchesCount(int t)
        {
            int c;
            Console.WriteLine("\n", (t == 0) ? "Player 1" : "Player 2");
            Console.WriteLine("How many matches you want to take away?: ");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("You have entered an incorrect character!");
            } 
                if (c > 3 || c < 1)
                {
                    Console.WriteLine("Warning! You can take 1, 2 or 3 matches!\n\n");
                    return InputMatchesCount(t);
                }

                return c;
        }
        public void GameOver(bool palyerWon)
        {
            Console.Clear();

            if (palyerWon)
            {
                Console.WriteLine("\n\tYou Win!");
            }
            else
            {
                Console.WriteLine("\n\tYou Lose!");
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Continue? (y/N): ");

            char input = Console.ReadLine()[0]; ;

            if (input == 'y')
            {
                Console.Clear();
                return;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
