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
                AnsiConsole.MarkupLine($"\n[plum4]{npc}[/]");
                AnsiConsole.MarkupLine($"[steelblue1]{userChar}[/]");
                CombatMenu(userChar, npc);
            }
            if (npc.Health <= 0)
            {
                AnsiConsole.MarkupLine($"[plum4]{npc.Name}[/] has been [green]defteated![/]");
                userChar.IncreaseExp(userChar, npc);
                userChar.RoomsCleared++;
                Console.ReadKey();
                AnsiConsole.MarkupLine($"You start searching the carcase of [plum4]{npc.Name}[/]");
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
            Console.WriteLine("\n");
            var menuChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()

                  .AddChoices(new[] {"[green]Normal Attack[/]", "[yellow]Special Attack[/]",
                      "[purple]Open Bag[/]", "[orange4_1]Run Away[/]"

                  }));
            switch (menuChoice)
            {
                case "[green]Normal Attack[/]":
                    {
                        Console.Clear();
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
                        Console.Clear();
                        int dmg = userChar.SpecialAttackMethod(userChar);
                        if (dmg == 0)
                        {
                            Console.WriteLine($"You are out of special Energy, either use a SpecialEnergyPotion, or normal attack");
                            CombatMenu(userChar, npc);
                        }
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
                case "[purple]Open Bag[/]":
                    {   Console.Clear();
                        Items.UsingItems(userChar);
                        AnsiConsole.Clear();
                    }break;
                case "[orange4_1]Run Away[/]":
                    {
                        Console.Clear();
                        int dmg = Character.NormalAttackMethod(userChar);
                        Console.WriteLine("You turn around and starts running back to the door you came from..");
                        Console.ReadKey();
                        AnsiConsole.MarkupLine($"But {npc.Name} strikes you in the back causing {dmg} damage");
                        userChar.Health -= dmg;
                        Console.ReadKey();
                        AnsiConsole.MarkupLine("Eventually you make it out!");
                        Console.ReadKey();
                        Dialog.NextRoomOrMenu(userChar);
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
