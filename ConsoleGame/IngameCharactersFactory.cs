using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal static class IngameCharactersFactory
    {
        public static IngameCharacters Create(CreatersType creaters) 
        {
            switch(creaters)
            {
                case CreatersType.Ork:
                    return new Ork();
                    break;
                case CreatersType.Elf:
                    return new Elf();
                    break;
                case CreatersType.Human:
                    return new Human();
                    break;
                case CreatersType.Bear:
                    return new Bear();
                case CreatersType.Wolf:
                    return new Wolf();
                case CreatersType.Raven:
                    return new Raven();
                case CreatersType.Fox:
                    return new Fox();
                case CreatersType.Boar:
                    return new Boar();
                    break;
            }
            return null;
        } 
    }
}
