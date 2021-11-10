using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Combat
    {
        public static void CombatScene(Character userChar, Character npc)
        {
            while (userChar.Health > 0 && npc.Health > 0)
            {
                Console.WriteLine(npc);
                Console.WriteLine(userChar);
                CombatMenu(userChar, npc);
            }
            if (npc.Health <= 0)
            {
                userChar.Experience += (npc.Level * 5);
            }
        }
        private static void CombatMenu(Character userChar, Character npc)
        {
            var menuChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()

                  .AddChoices(new[] {"[green]Normal Attack[/]", "[yellow]Special Attack[/]", "[orange4_1]Run Away[/]"

                  }));
            switch (menuChoice)
            {
                case "[green]Normal Attack[/]":
                    {
                        int dmg = Character.NormalAttackMethod(userChar);
                        Console.WriteLine($"{userChar.Name} uses Normal Attack on {npc.Name} causing {dmg} damage ");
                        npc.Health -= dmg;
                        Console.ReadKey();
                        Console.WriteLine($"{npc.Name} Strikes back on {userChar.Name} causing {npc.NormalAttack} damage ");
                        userChar.Health -= npc.NormalAttack;
                        Console.ReadKey();
                    }
                    break;
                case "[yellow]Special Attack[/]":
                    {
                        int dmg = Character.SpecialAttackMethod(userChar);
                        Console.WriteLine($"{userChar.Name} uses Special Attack on {npc.Name} causing {dmg} damage ");
                        npc.Health -= dmg;
                        //userChar.SpecialMana -= userChar.Drain;
                        Console.ReadKey();
                        Console.WriteLine($"{npc.Name} Strikes back on {userChar.Name} causing {npc.NormalAttack} damage ");
                        userChar.Health -= npc.NormalAttack;
                        Console.ReadKey();
                    }
                    break;
                case "[orange4_1]Run Away[/]":
                    {

                    }
                    break;
                default:
                    break;
            }
        }
        
    }
}
