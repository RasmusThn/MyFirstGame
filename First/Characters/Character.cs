using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static First.Items;

namespace First
{
    class Character
    {
        public List<DropItems> ItemsList;
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int NormalAttack { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int ExpReqPerLvl { get; set; }
        public int SpecialEnergy { get; set; }
        public int MaxSpecialEnergy { get; set; }
        public int SpecialPower { get; set; }
        public int RoomsCleared { get; set; }
        public string Class { get; set; }
        
        public Character()
        {

        }
        public Character(string aName)
        {
            this.ItemsList = new List<DropItems>();
            this.Name = aName;
            this.Level = 1;
            this.Experience = 0;
            this.ExpReqPerLvl = 100;
            this.RoomsCleared = 0;
            for (int i = 0; i < CharList.ListOfChars.Count; i++)
            {
                if (CharList.ListOfChars[i].Name == null)
                {
                    CharList.ListOfChars.RemoveAt(i);
                    CharList.ListOfChars.Insert(i, this);
                    break;
                }

            }
            

        }// Adds new chars..
        public Character(Character character)
        {
            this.Class = character.Class;
            this.Health = character.Health;
            this.MaxHealth = character.MaxHealth;
            this.SpecialEnergy = character.SpecialEnergy;
            this.SpecialPower = character.SpecialPower;
            this.NormalAttack = character.NormalAttack;
            this.MaxSpecialEnergy = character.MaxSpecialEnergy;
            this.ItemsList = character.ItemsList;
            this.Name = character.Name;
            this.Level = character.Level;
            this.Experience = character.Experience;
            this.ExpReqPerLvl = character.ExpReqPerLvl;
            this.RoomsCleared = character.RoomsCleared;

            for (int i = 0; i < CharList.ListOfChars.Count; i++)
            {
                if (CharList.ListOfChars[i].Name == null)
                {
                    CharList.ListOfChars.RemoveAt(i);
                    CharList.ListOfChars.Insert(i, this);
                    break;
                }

            }
        } //Adds chars from saved file
        internal static int NormalAttackMethod(Character userChar)
        {
            Random random = new Random();
            return random.Next(userChar.NormalAttack - 3, userChar.NormalAttack);
        }
        public virtual int SpecialAttackMethod(Character userChar)
        {
            Random rand = new Random();
            return rand.Next(userChar.SpecialPower - 3, userChar.SpecialPower + 5);
        }
        public static Character FromNameToObject(string name)
        {
            List<Character> characters = CharList.ListOfChars.Where(x => x.Name == name).ToList();
            //TODO: Lägg till if null
            return characters[0];
        }
        public void IncreaseExp(Character userChar, Character npc)
        {
            int increase = (npc.Level * 2) + 25;
            userChar.Experience += increase;
            Console.WriteLine($"You gained {increase} Experience");
            if (userChar.Experience >= ExpReqPerLvl)
            {
                LevelUp(userChar);
            }

        }
        public virtual void LevelUp(Character userChar)
        {
            userChar.Experience -= Experience;
            userChar.Level += 1;
            userChar.ExpReqPerLvl += 25;

            AnsiConsole.MarkupLine($"[Green]Hurray [steelblue1]{userChar.Name}[/] you just reached level[/][steelblue1] {userChar.Level}[/]");

        }
    }
}
