﻿using System;
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
            Game game = new Game();
            int sum = game.sumGame();
            Console.WriteLine("The sum of the three dice rolls is: " + sum);

            Testing testing = new Testing();
            testing.Tests();
        }
    }
}
