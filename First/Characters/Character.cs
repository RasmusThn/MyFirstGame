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
    }
}
