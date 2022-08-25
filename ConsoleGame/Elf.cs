using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Elf : NonplayingCharakter
    {
        private Random healRange = new Random();
        private Random randomName = new Random();
        string[] arrayNames = new string[] { "Elf Buddy ", "Elf Dobby ", "Elf Winky ", "Elf Kreacher " };
        private  void NPCNames()
        {
            int elfName = randomName.Next(0, arrayNames.Length);
            Console.WriteLine($"You have just meet with {arrayNames[elfName]}");
        }

        public override void InteractionWithNPC(MainCharacter mainCharacter)
        {
            NPCNames();
            Console.WriteLine($"Your health points are: {mainCharacter.GetHealth()}");

            int randomHeal = healRange.Next(5, 15);
            mainCharacter.Heal(randomHeal);

            Console.WriteLine($"You took {randomHeal} heal");
            Console.WriteLine();

        }
    }

}
