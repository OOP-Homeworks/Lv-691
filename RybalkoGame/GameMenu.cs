using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoGame
{
    internal class GameMenu : GameSettings
    {
        public void MainMenu()
        {
            while (true)
            {

                Console.Clear();
                DrawMainMenu(_m_cnt, _players);
                Console.WriteLine("\t ");
                string input = Console.ReadLine();
                Console.WriteLine("\n");

                switch (input[0])
                {
                    case '1':
                        GameLoop(_m_cnt, _players);
                        break;
                    case '2':
                        Console.WriteLine("\tSet matches count> ");
                        _m_cnt = int.Parse(Console.ReadLine());

                        break;
                    case '3':
                        _players = TogleZeroOne(_players);
                        break;
                    case '4':
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
