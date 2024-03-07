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
            dice = new Die[3]; // Empty array of 3 Die objects
            for (int i = 0; i < 3; i++) 
            {                          // 16 - 18 creates an instance for the Die class for each empty slot in the array.
                dice[i] = new Die(); 
            }
        }

        public int sumGame()
        {
            int sum = 0; // Initival value of sum is set to 0
            foreach (var die in dice)
            {
                sum += die.Roll(); // Adds Roll results to the sum
            }
            return sum;
        }

    }
}
