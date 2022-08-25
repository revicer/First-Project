using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{

    abstract class IngameCharacters : ICharacter
    {
        public abstract void InteractionWithNPC(MainCharacter mainCharacter);

    }
}
