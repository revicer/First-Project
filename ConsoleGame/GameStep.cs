using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class GameStep
    {
        private RandomHelper _nextStepRandom = new RandomHelper();
        private Random _stepPhraseRandom = new Random();
        private string[] _arrayEmptyStepPhrase = new string[] { "It's beautiful here", "I would like to meet someone", "Maybe I should take a break?", "I haven't been here before" };

        public int NPCCount = 0;

        Random randomAnimal = new Random();
        string[] animals = new string[] { "bear", "raven", "wolf", "fox", "boar" };
        Dictionary<string, CreatersType> Animals = new Dictionary<string, CreatersType>() { };

        Random randomMeet = new Random();
        string[] strangers = new string[] { "ork", "elf", "human" };
        Dictionary<string, CreatersType> NPC = new Dictionary<string, CreatersType>() { };


        public void Configurate()
        {

            NPC.Add("ork", CreatersType.Ork);
            NPC.Add("elf", CreatersType.Elf);
            NPC.Add("human", CreatersType.Human);


            Animals.Add("bear", CreatersType.Bear);
            Animals.Add("raven", CreatersType.Raven);
            Animals.Add("wolf", CreatersType.Wolf);
            Animals.Add("fox", CreatersType.Fox);
            Animals.Add("boar", CreatersType.Boar);
        }


        public void InGameStep(MainCharacter mainCharacter)
        {
            if (_nextStepRandom.Roll(30))
            {
                MeetNoone();
                return;
            }

            else if (_nextStepRandom.Roll(30))
            {
                MeetAnimal(mainCharacter);
                return;
            }

            else MeetNPC(mainCharacter);

        }
        private void MeetNoone()
        {
            int randomPhrase = _stepPhraseRandom.Next(_arrayEmptyStepPhrase.Length);
            Console.WriteLine();
            Console.WriteLine($"Your character said: {_arrayEmptyStepPhrase[randomPhrase]}");
            Console.WriteLine();
            Console.WriteLine();
        }
        private void MeetAnimal(MainCharacter mainCharacter)
        {
            int randomAnimalNumber = randomAnimal.Next(animals.Length);
            Console.WriteLine();

            CreatersType actualAnimal = Animals.FirstOrDefault(x => x.Key == animals[randomAnimalNumber]).Value;
            var checkCreaters = IngameCharactersFactory.Create(actualAnimal);
            checkCreaters.InteractionWithNPC(mainCharacter);
        }
        private void MeetNPC(MainCharacter mainCharacter)
        {
            NPCCount++;
            int randomStrangers = randomMeet.Next(strangers.Length);
            Console.WriteLine();

            CreatersType actualNPC = NPC.FirstOrDefault(x => x.Key == strangers[randomStrangers]).Value;
            var checkNPC = IngameCharactersFactory.Create(actualNPC);
            checkNPC.InteractionWithNPC(mainCharacter);
        }


    }
}
