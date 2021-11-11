using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
     class Items
    {
        //public List<DropItems> itemsList = new List<DropItems>(); 
        public enum DropItems
        {
            HealthPotion = 1,
            SpecialEnergyPotion = 2,
            WeaponUpgrade = 3,
            GearUpgrade = 4,
            ExpPotion = 5,
            Nothing = 6,
            Dust = 7,
            Emptiness = 8,
            Air = 9,
            Apple = 10,

        }
        public static void ShowBag(Character userChar)
        {
            foreach (DropItems item in userChar.ItemsList)
            {
                AnsiConsole.MarkupLine($"[green]{item}[/]");
            }
        }
        public static void SearchRoom(Character userChar)
        {
            
            Random rand = new Random();
            int randNum = rand.Next(1,10);
            DropItems dropItems = (DropItems)randNum;
            AnsiConsole.MarkupLine($"You found a [green]{dropItems}[/]");
            userChar.ItemsList.Add(dropItems);
        }
    }
}
