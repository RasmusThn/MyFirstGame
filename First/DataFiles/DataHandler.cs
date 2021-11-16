using First.Characters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace First.DataFiles
{
    internal class DataHandler
    {
        public static void SaveToFile()
        {
            string path = @"../../../DataFiles/SavedCharacters.json";
            string characters = JsonConvert.SerializeObject(CharList.ListOfChars);
            File.WriteAllText(path, characters);
        }
        public static void LoadFromFile()
        {
            string path = @"../../../DataFiles/SavedCharacters.json";
            string readJson = File.ReadAllText(path);
            List<Character> characters = JsonConvert.DeserializeObject<List<Character>>(readJson);
            
            foreach (Character character in characters)
            {
                if (character.Class == "Warrior")
                {
                     new Warrior(character);
                }
                //CharList.ListOfChars.Insert(x,character);
                else if (character.Class == "Mage")
                {
                    new Mage(character);
                }
                else if (character.Class == "Archer")
                {
                    new Archer(character);
                }
                else
                {
                    new Character(character);
                }
                
            }


        }
    }
}
