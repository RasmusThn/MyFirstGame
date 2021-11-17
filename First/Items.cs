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
            Blood = 10,

        }
        public static void ShowBag(Character userChar)
        {
            int x = 1;
            foreach (DropItems item in userChar.ItemsList)
            {
                AnsiConsole.MarkupLine($"{x}: [green]{item}[/]");
                x++;
            }
        }
        public static void SearchEnemy(Character userChar)
        {
            
            Random rand = new Random();
            int randNum = rand.Next(1,10);
            DropItems dropItems = (DropItems)randNum;
            AnsiConsole.MarkupLine($"You found [green]{dropItems}[/]");
            userChar.ItemsList.Add(dropItems);
        }
        public static void UsingItems(Character userChar)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"You have {userChar.ItemsList.Count} items in your bag.");          
            ShowBag(userChar);
            Console.Write($"Which item would you like to use(0 to return): ");
            int choice = int.Parse(Console.ReadLine());//TODO: Try catch
            Console.ResetColor();
            if (choice == 0 ){  return;}
            if (userChar.ItemsList[choice-1] == DropItems.HealthPotion )
            {
                Console.WriteLine("You drink a " + DropItems.HealthPotion.ToString());
                Console.WriteLine("Your health increases with 50 ");
                userChar.Health += 50;
            }
            else if (userChar.ItemsList[choice - 1] == DropItems.SpecialEnergyPotion)
            {
                Console.WriteLine("You drink a " + DropItems.SpecialEnergyPotion.ToString());
                Console.WriteLine("Your Special Energy increases with 50 ");
                userChar.SpecialEnergy += 50;
            }
            else if (userChar.ItemsList[choice -1] == DropItems.ExpPotion)
            {
                Console.WriteLine("You drink a " + DropItems.ExpPotion.ToString());
                Console.WriteLine("Your Experience increases with 50 ");
                userChar.Experience += 50;
            }
            else if (userChar.ItemsList[choice - 1] == DropItems.WeaponUpgrade)
            {
                Console.WriteLine("You use the " + DropItems.WeaponUpgrade.ToString());
                Console.WriteLine("Increasing your attacking by 5");
                userChar.SpecialPower += 3;
                userChar.NormalAttack += 2;
            }
            else if (userChar.ItemsList[choice - 1] == DropItems.GearUpgrade)
            {
                Console.WriteLine("You use the " + DropItems.GearUpgrade.ToString());
                Console.WriteLine("Increasing your max health by 20");
                userChar.MaxHealth += 20;

            }
            else
            {
                Console.WriteLine("Nothing Happens! Well what did you except?");
            }
            userChar.ItemsList.RemoveAt(choice - 1);
            DataFiles.DataHandler.SaveToFile();
        }
    }
}
