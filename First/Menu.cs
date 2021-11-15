﻿using First.Characters;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace First
{
    class Menu
    {
        public static void ShowMenu()
        {
            var menuChoice = string.Empty;
            do
            {
                Console.Clear();
                var rule = new Rule("[DarkCyan] M F G [/]");
                AnsiConsole.Write(rule);               
                menuChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                   
                   .AddChoices(new[] {"[steelblue1]New Character[/]", "[yellow]Choose Character[/]", "[orange4_1]Show Character Stats[/]", "[red]Exit Game[/]"

                   }));

                switch (menuChoice)
                {
                    case "[steelblue1]New Character[/]":
                        {
                            Character userChar = CreateCharacter();
                            DataFiles.DataHandler.SaveToFile();
                        }
                        break;
                    case "[yellow]Choose Character[/]":
                        {
                            MenuForCharList();
                        }
                        break;
                    case "[orange4_1]Show Character Stats[/]":
                        {

                        }
                        break;
                    case "[red]Exit Game[/]":Console.Clear(); break;
                    default:
                        break;
                }
            } while (menuChoice != "[red]Exit Game[/]");
        }
        public static Character CreateCharacter()
        {
            string name = AnsiConsole.Ask<string>("[green]Enter your name:[/]");
            Console.Clear();
            var charChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title($"[green]Choose a Class for [/][green]{name}[/]")
                .AddChoices(new[] {"[red]Warrior[/]", "[yellow]Archer[/]", "[green]Mage[/]"

                }));
            Character character = new();
            switch (charChoice)
            {
                case "[red]Warrior[/]":
                    {
                        character = new Warrior(name);

                    }
                    break;
                case "[yellow]Archer[/]":
                    {
                        character = new Archer(name);

                    }
                    break;
                case "[green]Mage[/]":
                    {
                        character = new Mage(name);

                    }
                    break;
                default:        
                    break;
            }

            return character;
        }
        public static string DisplayCharacterList(int index)
        {
            if (CharList.ListOfChars[index].Name == null)
            {
                return "Empty";
            }
            else
            return CharList.ListOfChars[index].Name;

        }
        public static void MenuForCharList()
        {
            Console.Clear();
            string name0 = DisplayCharacterList(0);
            string name1 = DisplayCharacterList(1);
            string name2 = DisplayCharacterList(2);
            string name3 = DisplayCharacterList(3);
            string name4 = DisplayCharacterList(4);
            var charChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
             .Title($"[green]Menu[/]")
             .AddChoices(new[] {name0,name1,name2,name3,name4
                   }));
            if (charChoice == "Empty")
            {
                Console.WriteLine("You can't choose an empty char, choose again or create a new one");
                Console.ReadKey();
            }
            else if (charChoice == name0)
            {
                Character userChar = Character.FromNameToObject(name0);
                Dialog.ChoosenChar(userChar);
            }
            else if (charChoice == name1)
            {
                Character userChar = Character.FromNameToObject(name1);
                Dialog.ChoosenChar(userChar);
            }
            else if (charChoice == name2)
            {
                Character userChar = Character.FromNameToObject(name2);
                Dialog.ChoosenChar(userChar);
            }
            else if (charChoice == name3)
            {
                Character userChar = Character.FromNameToObject(name3);
                Dialog.ChoosenChar(userChar);
            }
            else if (charChoice == name4)
            {
                Character userChar = Character.FromNameToObject(name4);
                Dialog.ChoosenChar(userChar);
            }
        }
    }
}
