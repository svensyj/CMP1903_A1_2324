using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); // Creates new instance of Game class
            int sum = game.sumGame(); // Rolls all dice in the current Game instance and calculates the total sum.

            Console.WriteLine("The sum of the three dice rolls is: " + sum); // Outputs sum to console

            Testing testing = new Testing(); // Creates Testing class instance
            testing.Tests(); // Calls the Tests to execute the tests needed

            Console.ReadLine();
        }
    }
}
