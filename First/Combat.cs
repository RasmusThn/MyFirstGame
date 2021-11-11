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
                AnsiConsole.MarkupLine($"[plum4]{npc}[/]");
                AnsiConsole.MarkupLine($"[steelblue1]{userChar}[/]");
                CombatMenu(userChar, npc);
            }
            if (npc.Health <= 0)
            {
                Console.WriteLine(npc.Name + " has been defteated!");
                userChar.IncreaseExp(userChar, npc);              
                userChar.RoomsCleared++;
                Console.ReadKey();
                Console.WriteLine("You start to search the room before leaving...");
                Items.SearchRoom(userChar);
                DataFiles.DataHandler.SaveToFile();//Sparar till fil här
                Dialog.WinningDialog(userChar);
            }
            else
            {
                Dialog.LosingDialog(userChar);
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
                        AnsiConsole.MarkupLine($"[steelblue1]{userChar.Name}[/] uses [green]Normal Attack[/] on [plum4]{npc.Name}[/] causing [red]{dmg} damage[/] ");
                        npc.Health -= dmg;
                        Console.ReadKey();
                        if (npc.Health > 0)
                        {
                            dmg = Character.NormalAttackMethod(npc);
                            AnsiConsole.MarkupLine($"[plum4]{npc.Name}[/] Strikes back on [steelblue1]{userChar.Name}[/] causing [red]{dmg} damage[/] ");
                            userChar.Health -= dmg;
                            Console.ReadKey();
                        }
                    }
                    break;
                case "[yellow]Special Attack[/]":
                    {
                        int dmg = userChar.SpecialAttackMethod(userChar);
                        AnsiConsole.MarkupLine($"[steelblue1]{userChar.Name}[/] uses [yellow]Special Attack[/] on [plum4]{npc.Name}[/] causing [red]{dmg} damage[/] ");
                        npc.Health -= dmg;
                        
                        Console.ReadKey();
                        if (npc.Health > 0)
                        {
                            dmg = Character.NormalAttackMethod(npc);
                            AnsiConsole.MarkupLine($"[plum4]{npc.Name}[/] Strikes back on [steelblue1]{userChar.Name}[/] causing [red]{dmg} damage[/]");
                            userChar.Health -= dmg;
                            Console.ReadKey();
                        }
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
