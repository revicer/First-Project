using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Ork : NonplayingCharakter 
    {
        private Random damageRange = new Random();
        private Random randomName = new Random();
        string[] arrayNames = new string[] { "Ork Gharkul", "Ork Uruk", "Ork Ghenghiz", "Ork Ghurrk" };

        private void NPCNames()
        {
            int orkName = randomName.Next(0, arrayNames.Length);
            Console.WriteLine($"You have just meet with {arrayNames[orkName]}");
        }

        public override void InteractionWithNPC(MainCharacter mainCharacter)
        {
            NPCNames(); 

            Console.WriteLine($"Your health points are: {mainCharacter.GetHealth()}");

            int randomDamage = damageRange.Next(15, 30);
            mainCharacter.SetDamage(randomDamage);

            Console.WriteLine($"You took {randomDamage} damage");
            Console.WriteLine();

        }
    }

}
