using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public Die[] dice;

        public Game()
        {
            dice = new Die[3];
            for (int i = 0; i < 3; i++)
            {
                dice[i] = new Die();
            }
        }

        public int sumGame()
        {
            int sum = 0;
            foreach (var die in dice)
            {
                sum += die.Roll();
            }
            return sum;
        }

    }
}
