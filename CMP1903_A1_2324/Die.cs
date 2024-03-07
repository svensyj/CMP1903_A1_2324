using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private Random random; // Private variable used to generate random numbers
        public int dieRolled {get; private set;} // This is where the result of a die roll will get placed into

        public Die()
        {
            random = new Random(); // Starts randomising when a Die object is created
            dieRolled = 0; // Initial value of DieRolled is 0
        }

        public int Roll()
        {
            dieRolled = random.Next(1, 7); // Generates random number between 1 and 6, and then the DieRolled will be stored in the property waiting to be used.
            return dieRolled;
        }

    }
}
