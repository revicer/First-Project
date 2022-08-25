using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Raven : Animal
    {
        public override void InteractionWithNPC(MainCharacter mainCharacter)
        {
            Console.WriteLine("You saw a raven that flew out behind a tree");
            Console.WriteLine();
        }
    }
}
