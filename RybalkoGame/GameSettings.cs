using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoGame
{
    internal class GameSettings:GameInterface
    {
        public int _m_cnt = 15;// кількість сірників
        public int _players = 0;// 0 - ігрок, 1-комп'ютер, хто другий ігрок
        public int turn = 0;//0 - ігрок, 1-комп'ютер, хто ходить
        public int cnt;//скільки сирників забираємо
        public void GameLoop(int m, int p)
        {
            int matches_count = m;
            int players = p;
            WaitForSeconds(1);
            Console.Clear();

            do
            {

                DrawGameInterface(matches_count);
                if (turn == 0)
                {
                    cnt = InputMatchesCount(turn);
                    matches_count -= cnt;
                    turn = 1;
                }
                else
                {
                    if (players == 1)
                    {
                        cnt = InputMatchesCount(turn);
                    }
                    else
                    {
                        Console.WriteLine("Computer:\n");
                        Console.WriteLine("How many matches you want to take away?: ");
                        WaitForSeconds(new Random().Next(1, 2));

                        cnt = matches_count % 4 + 1;
                        if (matches_count <= 4) cnt = matches_count - 1;
                        if (cnt == 0) cnt = 1;

                        Console.WriteLine($"{cnt}\n");
                        WaitForSeconds(1);
                    }
                    matches_count -= cnt;
                    turn = 0;
                }
                WaitForSeconds(3);
                Console.Clear();
            } while (matches_count > 0);

            // Кінець гри
            if (turn == 0)
            {
                // перемога гравця
                GameOver(true);
            }
            else
            {
                // перемога комп'ютера
                GameOver(false);
            }
        }
        public void WaitForSeconds(int s)
        {
            Thread.Sleep(s*1000);
        }
        public int TogleZeroOne(int x)
        {
            if (x == 0) x = 1;
            else x = 0;
            return x;
        }
    }
}
