namespace ConsoleGame
{
    public class GameProcess
    {
        public void StartGame()
        {
            MainCharacter mainCharacter = new MainCharacter();

            while (true)
            {
                Console.WriteLine("Enter name of the main character:");
                mainCharacter.MainCharaсterName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(mainCharacter.MainCharaсterName))
                {
                    break;
                }
            }


            while (true)
            {
                Console.WriteLine("Choose profession: 0 - Magician, 1 - Warrior, 2 - Thief");
                string userProfession = Console.ReadLine();

                if (mainCharacter.TrySetProfession(userProfession))
                {
                    break;
                }
            }
            GameActivity(mainCharacter);
        }

        public void GameActivity(MainCharacter mainCharacter)
        {
            GameStep gameStep = new GameStep();
            UserInputHelper userInputHelper = new UserInputHelper();
            gameStep.Configurate();

            while (mainCharacter.IsAlive())
            {
                Console.WriteLine("Press space to the next travel:");
                ConsoleKey key = userInputHelper.GetButton();
                if (key == ConsoleKey.Spacebar)
                {
                    gameStep.InGameStep(mainCharacter);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You can press only space!");
                }
            }

            Console.WriteLine("Game is Over");
            Console.WriteLine($"You meat {gameStep.NPCCount} NPC");
        }
    }

}
