using First.Characters;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Dialog
    {

        public static void StartingDialog(Character userChar)
        {
            Console.Clear();
            AnsiConsole.MarkupLine($"[DarkCyan][steelblue1]{userChar.Name}[/] wakes up in a Dark Room...[/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan][steelblue1]{userChar.Name}[/] hears a noice coming from what he thinks is the other side of the room [/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan]A [yellow]light[/] appers at the end of the room, a room that now when [steelblue1]{userChar.Name}[/] is able to see again, is a narrow hallway[/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan]The room only has 1 [green]door[/] and it's blocked by something blurry..[/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan][steelblue1]{userChar.Name}[/] stands up and slowly starts walking towards the blurr..[/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan]The blurr starts to clear and [steelblue1]{userChar.Name}[/] see's what it is...[/]");
            Npc enemy = new(userChar);
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan]A Wild [plum4]{enemy.Name}[/] charges towards [steelblue1]{userChar.Name}[/][/]");
            Console.ReadKey();
            Combat.CombatScene(userChar, enemy);
        }
        public static void NextRoomOrMenu(Character userChar)
        {
            while (true)
            {
                Console.Clear();
                var rule = new Rule($"[steelblue1]{userChar.Name}[/]");
                AnsiConsole.Write(rule);

                var MenuChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    
                    .AddChoices(new[] {"[green]Continue[/]", "[orange4_1]Show Stats[/]",
                    "[yellow]Bag[/]", "[red]Return to Menu[/]"

                    }));

                switch (MenuChoice)
                {
                    case "[green]Continue[/]":
                        {
                            AnsiConsole.MarkupLine($"You move towards the Door");
                            Console.ReadKey();
                            NextRoom(userChar);
                        }
                        break;
                    case "[orange4_1]Show Stats[/]":
                        {
                            Console.Clear();
                            AnsiConsole.MarkupLine($"[red]Your stats are:[/][steelblue1] {userChar}[/]");
                            Console.ReadKey();
                        }
                        break;
                    case "[yellow]Bag[/]":
                        {
                            Console.Clear();
                            Items.UsingItems(userChar);
                            Console.ReadKey();
                        }
                        break;
                    case "[red]Return to Menu[/]":
                        {
                            Menu.ShowMenu();
                        }
                        break;

                    default:
                        break;
                }
            }
        }
        public static void NextRoom(Character userChar)
        {
            Console.Clear();
            AnsiConsole.MarkupLine($"[DarkCyan][steelblue1]{userChar.Name}[/] opens the door to room number [steelblue1]{userChar.RoomsCleared + 1}[/][/]");
            Console.ReadKey();

            AnsiConsole.MarkupLine($"[DarkCyan][steelblue1]{userChar.Name}[/] enters the room and the door slams behind.. [/]");
            Console.ReadKey();

            if (((userChar.RoomsCleared + 1) * 7) % 5 == 0)
            {
                Boss boss = new(userChar);
                AnsiConsole.MarkupLine($"[DarkCyan]A large Boss [red]{boss.Name}[/] appears infront of [steelblue1]{userChar.Name}[/][/]\n");
                Console.ReadKey();
                Combat.CombatScene(userChar, boss);
            }
            else
            {
                Npc enemy = new(userChar);
                AnsiConsole.MarkupLine($"[DarkCyan]A Wild [plum4]{enemy.Name}[/] appears infront of [steelblue1]{userChar.Name}[/][/]\n");
                Console.ReadKey();
                Combat.CombatScene(userChar, enemy);
            }

        }
        public static void ChoosenChar(Character userChar)
        {
            AnsiConsole.MarkupLine($"[red]You have choosen[/][steelblue1] {userChar.Name}[/]");
            AnsiConsole.MarkupLine($"[red]Your stats are:[/][steelblue1] {userChar}[/]");
            Console.WriteLine("\n");
            StartGameOrMenu(userChar);

        }
        public static void StartGameOrMenu(Character userChar)
        {

            Console.Clear();
            var rule = new Rule($"[steelblue1]{userChar.Name}[/]");
            AnsiConsole.Write(rule);
            var MenuChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()

                .AddChoices(new[] {"[green]Start Game[/]", "[yellow]Choose Another Character[/]","[red]Delete Character[/]", "[green]Return to Menu[/]"

                }));
            switch (MenuChoice)
            {
                case "[green]Start Game[/]":
                    {
                        if (userChar.RoomsCleared == 0)
                        {
                            StartingDialog(userChar);
                        }
                        else
                        {
                            NextRoomOrMenu(userChar);
                        }
                    }
                    break;
                case "[yellow]Choose Another Character[/]":
                    {
                        Menu.MenuForCharList();
                    }
                    break;
                case "[red]Delete Character[/]":
                    {
                        DeleteCharacter(userChar);
                    }
                    break;
                case "[green]Return to Menu[/]":
                    {
                        Menu.ShowMenu();
                    }
                    break;
                default:
                    break;
            }
        }

        private static void DeleteCharacter(Character userChar)
        {
            AnsiConsole.MarkupLine($"Are you sure that you would like to delete {userChar.Name} ?");
            var menuChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()

                .AddChoices(new[] {"[red]Yes[/]","[green]No[/]"

                }));
            switch (menuChoice)
            {
                case "[red]Yes[/]":
                    {
                        CharList.ListOfChars.Remove(userChar);
                        Character character = new Character();
                        CharList.ListOfChars.Add(character);
                        DataFiles.DataHandler.SaveToFile();
                        Console.WriteLine("Character removed..");
                        Console.ReadKey();
                        Menu.ShowMenu();
                    }break;
                case "[green]No[/]":
                    {
                        StartGameOrMenu(userChar);
                    }
                    break;
                default:
                    break;
            }
        }

        public static void WinningDialog(Character userChar)
        {
            Console.WriteLine();
            AnsiConsole.MarkupLine($"[green]Congratulations![/]");
            Console.ReadKey();
            Console.Clear();
            NextRoomOrMenu(userChar);
        }
        public static void LosingDialog(Character userChar)
        {
            Console.WriteLine("Sorry but you died");
            Console.WriteLine("returning to menu...");
            Menu.ShowMenu();
        }
    }
}
