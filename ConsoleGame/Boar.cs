using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Boar : Animal
    {
        private Random _damageRange = new Random();
        private RandomHelper _attackChanse = new RandomHelper();
        public override void InteractionWithNPC(MainCharacter mainCharacter)
        {
            Console.WriteLine("You heard sounds from the forest. It was a boar");
            if (_attackChanse.Roll(40))
            {
                Console.WriteLine("The boar was scared of you and ran away");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("The boar furiously ran towards you!");
            Console.WriteLine($"Your health points are: {mainCharacter.GetHealth()}");

            int randomDamage = _damageRange.Next(5, 10);
            mainCharacter.SetDamage(randomDamage);
            Console.WriteLine($"You took {randomDamage} damage");
            Console.WriteLine();
        }
    }
}
