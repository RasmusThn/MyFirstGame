using First.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int NormalAttack { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int ExpReqPerLvl { get; set; }
        

        //public static List<Character> charList = new(5);

        public Character()
        {
            
        }

        public Character(string aName)
        {
            this.Name = aName;
            this.Level = 1;
            this.Experience = 0;
            this.ExpReqPerLvl = 100;
            this.NormalAttack = 5;
            for (int i = 0; i < CharList.ListOfChars.Count; i++)
            {
                if (CharList.ListOfChars[i].Name == null)
                {
                    CharList.ListOfChars.Insert(i, this);
                    break;
                }             
                
            }
            
        }
        public static Character FromNameToObject(string name)
        {
            List<Character> characters = CharList.ListOfChars.Where(x => x.Name == name).ToList();

            return characters[0];
        }
        public static int NormalAttackMethod(Character character)
        {
            Random random = new Random();
            return random.Next(character.NormalAttack - 2, character.NormalAttack + 2);
            
        }
        public static int SpecialAttackMethod(Character character)
        {
            Random rand = new Random();
            return rand.Next(5, 10);
        }

        public static int SpecialAttackMethod(Mage mage)
        {
            mage.Mana -= 20;
            Random rand = new Random();
            return rand.Next(mage.SpellPower - 5, mage.SpellPower + 5);
        }
        public static int SpecialAttackMethod(Warrior warrior)
        {
            warrior.Rage -= 10;
            Random rand = new Random();
            return rand.Next(warrior.AttackPower - 5, warrior.AttackPower + 5);
        }
        public static int SpecialAttackMethod(Archer archer)
        {
            archer.RangedAttackPower -= 10;
            Random rand = new Random();
            return rand.Next(archer.RangedAttackPower - 5, archer.RangedAttackPower + 5);
        }
    }
}
