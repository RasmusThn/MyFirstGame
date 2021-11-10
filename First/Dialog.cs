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
            AnsiConsole.MarkupLine($"[DarkCyan]{userChar.Name} wakes up in a Dark Room...[/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan]{userChar.Name} hears a noice coming from what he thinks is the other side of the room [/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan]A [yellow]light[/] appers at the end of the room, a room that now when {userChar.Name} is able to see again, is a narrow hallway[/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan]The room only has 1 [green]door[/] and it's blocked by something blurry..[/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan]{userChar.Name} stands up and slowly starts walking towards the blurr..[/]");
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan]The blurr starts to clear and {userChar.Name} see's what it is...[/]");
            Npc enemy = new(userChar);
            Console.ReadKey();
            AnsiConsole.MarkupLine($"[DarkCyan]A Wild [red]{enemy.Name}[/] charges towards {userChar.Name}[/]");
            Console.ReadKey();
        }
        public static void ChoosenChar(Character userChar)
        {
            AnsiConsole.MarkupLine($"[red]You have choosen[/][green] {userChar.Name}[/]");
            AnsiConsole.MarkupLine($"[red]Your stats are:[/]\n\n[green] {userChar}[/]");
            Console.WriteLine("\n\n");
            ReturnToMenuQuestion(userChar);
           
        }
        public static void ReturnToMenuQuestion(Character userChar)
        {
            
            //Console.Clear();
            var MenuChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                
                .AddChoices(new[] {"[green]Start Game[/]", "[yellow]Choose Another Character[/]", "[green]Return to Menu[/]"

                }));
            switch (MenuChoice)
            {
                case "[green]Start Game[/]":
                    {
                        StartingDialog(userChar);
                    }break;
                case "[yellow]Choose Another Character[/]":
                    {
                        Menu.MenuForCharList();
                    }break;
                case "[green]Return to Menu[/]":
                    {
                        Menu.ShowMenu();
                    }break;
                default:
                    break;
            }
        }
    }
}
