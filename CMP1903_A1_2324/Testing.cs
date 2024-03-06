using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {

        public void Tests()
        {
            Game game = new Game();
            int sum = game.sumGame();
            Debug.Assert(sum >= 3 && sum <= 18, "Sum of dice is not between 3 and 18.");
            foreach (var die in game.dice)
            {
                Debug.Assert(die.dieRolled >= 1 && die.dieRolled <= 6, "Die is not between 1 and 6");
            }

            Console.WriteLine("Tests have been passed successfully.");

        }
    }
}
