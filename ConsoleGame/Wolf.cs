using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Wolf : Animal
    {
        private Random _damageRange = new Random();
        private RandomHelper _attackChanse = new RandomHelper();
        public override void InteractionWithNPC(MainCharacter mainCharacter)
        {
            Console.WriteLine("On your path you saw a wolf");
            if (_attackChanse.Roll(40))
            {
                Console.WriteLine("The wolf did not notice you and went into the forest");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("The wolf has seen you!");
            Console.WriteLine($"Your health points are: {mainCharacter.GetHealth()}");

            int randomDamage = _damageRange.Next(5, 15);
            mainCharacter.SetDamage(randomDamage);
            Console.WriteLine($"You took {randomDamage} damage");
            Console.WriteLine();
        }
    }
}
