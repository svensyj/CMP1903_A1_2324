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
            Game game = new Game(); // Creates a new instnace of game class
            int sum = game.sumGame(); // Rolls all dice and takes the total amount of sum between die

            Debug.Assert(sum >= 3 && sum <= 18, "Sum of dice is not between 3 and 18."); // Assert the sum of the die is between 3 and 18
            foreach (var die in game.dice)
            {
                Debug.Assert(die.dieRolled >= 1 && die.dieRolled <= 6, "Die is not between 1 and 6"); // Assert that each die roll's result is within the range of 1 and 6
            }

            Console.WriteLine("Tests have been passed."); // Prints out to show that there are no errors

        }
    }
}
