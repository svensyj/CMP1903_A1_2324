using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private Random random;
        public int dieRolled {get; private set;}
        public Die()
        {
            random = new Random();
            dieRolled = 0;
        }

        public int Roll()
        {
            dieRolled = random.Next(1, 7);
            return dieRolled;
        }

    }
}
