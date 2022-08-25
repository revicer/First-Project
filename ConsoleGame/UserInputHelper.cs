using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class UserInputHelper
    {
        public ConsoleKey GetButton()
        {
            var but = Console.ReadKey().Key;

            return but;
        }
    }
}
