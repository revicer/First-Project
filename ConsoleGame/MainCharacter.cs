using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class MainCharacter
    {
        private int healthPoint = 100;
        public string MainCharaсterName;
        public CharacterClass prof;

        public void SetDamage(int damage)
        {
            healthPoint -= damage; 
        }

        public void Heal(int heal)
        {
            healthPoint += heal;

            if (healthPoint>100)
            {
                healthPoint = 100;
            }           
        }

        public int GetHealth()
        {
            return healthPoint;
        }

        public bool TrySetProfession(string profInPut)
        {
            var profNumberInput = int.TryParse(profInPut, out int res);

            if (profNumberInput)
            {
                if (Enum.IsDefined(typeof(CharacterClass), res))
                {
                    prof = (CharacterClass)res;
                    return true;
                }
            }
            return false;
        }

        public bool IsAlive()
        {
            if (healthPoint <=0)
            {
                return false;
            }
            return true;   
        }
    }

}
