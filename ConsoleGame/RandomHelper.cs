using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class RandomHelper
    {
        public bool Roll(int rollChanse)
        {
            Random randomNumber = new Random();
            int chanceСheck = randomNumber.Next(1,100);
            if (chanceСheck <= rollChanse)
            {
                return true;
            }
            return false;
        }
    }
}
