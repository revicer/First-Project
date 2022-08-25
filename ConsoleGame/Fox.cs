using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Fox : Animal
    {
        public override void InteractionWithNPC(MainCharacter mainCharacter)
        {
            Console.WriteLine("You saw a group of foxes drinking water near the lake");
            Console.WriteLine();
        }
    }
}
