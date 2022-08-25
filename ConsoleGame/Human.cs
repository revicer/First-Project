using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Human : NonplayingCharakter
    {
        private Random randomSong = new Random();
         string[] arraySongs = new string[] { "First song", "Second song", "Third song", "Fourth song" };
        private Random randomName = new Random();
         string[] arrayNames = new string[] { "Human Kyle", "Human John", "Human Bob", "Human Robert" };

        private  void NPCNames()
        {
            int humanName = randomName.Next(0, arrayNames.Length);
            Console.WriteLine($"You have just meet with {arrayNames[humanName]}");
        }
        public override void InteractionWithNPC(MainCharacter mainCharacter)
        {
            NPCNames();
            int numberSong = randomSong.Next(0, arraySongs.Length);
            Console.WriteLine($"This stranger sang you a {arraySongs[numberSong]}");
            Console.WriteLine();
        }

    }

}
