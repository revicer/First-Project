using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Bear : Animal
    {
        private Random _damageRange = new Random();
        private RandomHelper _attackChanse = new RandomHelper();
        public override void InteractionWithNPC(MainCharacter mainCharacter)
        {
            Console.WriteLine("From behind the bushes you saw a bear");
            if (_attackChanse.Roll(40))
            {
                Console.WriteLine("The bear calmly fished and you left");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("The bear saw you and chasing you!");
            Console.WriteLine($"Your health points are: {mainCharacter.GetHealth()}");

            int randomDamage = _damageRange.Next(10, 20);
            mainCharacter.SetDamage(randomDamage);
            Console.WriteLine($"You took {randomDamage} damage");
            Console.WriteLine();
        }
    }
}
