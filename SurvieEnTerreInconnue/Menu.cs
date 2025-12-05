using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SurvieEnTerreInconnue
{
    internal class Menu
    {
        /// <summary>
        /// Méthode qui traite les choix effectuer par l'utilisateur dans le menu principal.
        /// </summary>
        public static void ProcessDisplayMenuInput()
        {
            bool continueGame = true;

            while (continueGame)
            {
                ConsoleKey input = Display.DisplayMenu();

                switch (input)
                {
                    case ConsoleKey.D:
                        Map.hasStartedGame = true;
                        Display.DisplayGameHistory();
                        Map.ResetGame();
                        Map.ShowTerrainAtCurrentPosition();
                        Thread.Sleep(1000);
                        break;

                    case ConsoleKey.C:
                        Game.DataDeserialisation();
                        break;

                    case ConsoleKey.S:
                        Game.DataSerialisation();
                        break;

                    case ConsoleKey.A:
                        Console.Clear();
                        Display.DisplayProgrammersCredits();
                        Display.WaitForKeyPress("\n\nAppuyez sur une touche pour retourner au menu...");
                        break;

                    case ConsoleKey.Q:
                        continueGame = ProcessDisplayLeaveMessageInput();
                        break;

                    case ConsoleKey.Enter:
                        if(Map.hasStartedGame)
                        {
                            Map.ShowTerrainAtCurrentPosition();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Veuillez commencer une partie avant de pouvoir la continuer");
                            Console.ResetColor();
                            Display.WaitForKeyPress("\nAppuyez sur une touche pour retourner au menu principal");
                        }
                        break;

                    default:
                        Display.AnimateText("\nChoix invalide. Veuillez réessayer.");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        break;
                }
            }
        }

        /// <summary>
        /// Méthode qui traite les actions de l'utilisateur dans le menu de sorti du jeu
        /// </summary>
        public static bool ProcessDisplayLeaveMessageInput()
        {
            ConsoleKey input = Display.DisplayLeaveMessage();

            switch (input)
            {
                case ConsoleKey.O:
                    Console.Clear();
                    Console.ResetColor();  
                    DisplayGoodByeMessage();
                    Thread.Sleep(3000);
                    return false;
                case ConsoleKey.N:
                    return true;
                case ConsoleKey.S:
                    Game.DataSerialisation();
                    DisplayGoodByeMessage();
                    return false;
                default:
                    Console.ResetColor();  
                    Display.AnimateText("Choix invalide. Retour au menu...");
                    Thread.Sleep(1500);
                    ProcessDisplayMenuInput();
                    return true;
            }
        }

        /// <summary>
        /// Méthode qui affiche le message d'aurevoir à l'utilisateur
        /// </summary>
        public static void DisplayGoodByeMessage()
        {
            Console.Clear();
            Console.ResetColor();
            Display.WaitForKeyPress("\nAppuyez sur une touche pour fermer le jeu...");
            Process.GetCurrentProcess().Kill();
        }

        /// <summary>
        /// Méthode qui affiche les règles du jeu
        /// </summary>
        public static void DisplayGameRules()
        {
            Console.Clear();
            Console.ReadKey();
        }

        /// <summary>
        /// Méthode qui traite les choix effectué dans le menu de préparation
        /// </summary>
        public static void ProcessCookingMenuInput()
        {
            bool continueCooking = true;

            while (continueCooking)
            {
                ConsoleKey input = Display.DisplayCookingMenu();

                switch (input)
                {
                    case ConsoleKey.P:
                        Crafting.CookFish();
                        Display.WaitForKeyPress();
                        break;
                    case ConsoleKey.G:
                        Crafting.CookMeat();
                        Display.WaitForKeyPress();
                        break;
                    case ConsoleKey.A:
                        ProcessInventoryInput();
                        break;
                    case ConsoleKey.E:
                        Map.ShowTerrainAtCurrentPosition();
                        break;
                    case ConsoleKey.R:
                        ProcessDisplayManufacturingInput();
                        break;
                    case ConsoleKey.Escape: 
                        ProcessDisplayMenuInput();
                        continueCooking = false;
                        break;
                    case ConsoleKey.Q
                    :Display.DisplayLeaveMessage();
                        continueCooking = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Action annulée.");
                        break;
                }
            }
        }

        /// <summary>
        /// Méthode qui traite les choix effectué dans le menu de fabrication
        /// </summary>
        public static bool ProcessDisplayManufacturingInput()
        {
            bool continueManufacturing = true;

            while (continueManufacturing)
            {
                ConsoleKey input = Display.DisplayManufacturingMenu();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.F:
                        Console.Clear();
                        Crafting.BuildFire(); 
                        Display.WaitForKeyPress();
                        break;
                    case ConsoleKey.H:
                        Console.Clear(); 
                        Crafting.BuildAxe();
                        Display.WaitForKeyPress();
                        break;
                    case ConsoleKey.V:
                        Console.Clear();
                        Crafting.BuildGlass();
                        Display.WaitForKeyPress();
                        break;
                    case ConsoleKey.P:
                        Console.Clear();
                        Crafting.BuildPlank(); 
                        Display.WaitForKeyPress(); 
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        Crafting.BuildBrick();
                        Display.WaitForKeyPress();
                        break;
                    case ConsoleKey.I:
                        Console.Clear();
                        Crafting.BuildInsulator();
                        Display.WaitForKeyPress();
                        break;
                    case ConsoleKey.M:
                        Console.Clear();
                        Crafting.BuildHouse();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.N:
                        ProcessCookingMenuInput();
                        break;
                    case ConsoleKey.C:
                        ProcessInventoryInput();
                        break;
                    case ConsoleKey.Escape:
                        ProcessDisplayMenuInput();
                        return continueManufacturing = true;
                    case ConsoleKey.E: 
                        Map.GenerateMap();
                        Map.ShowTerrainAtCurrentPosition();
                        break;
                    case ConsoleKey.A: 
                        continueManufacturing = false;
                        break;    
                    case ConsoleKey.Q:
                        ProcessDisplayLeaveMessageInput(); 
                        return continueManufacturing = false;
                    default:Console.Clear();
                        Display.AnimateText("Action annulée");
                        break;
                }
            }
            return true;
        }

        /// <summary>
        /// Méthode qui traite les choix effectué dans l'inventaire principal
        /// </summary>
        public static void ProcessInventoryInput()
        {
            bool continueInventory = true;

            while (continueInventory)
            {
                ConsoleKey input = Display.DisplayInventoryPrincipalMenu();
                Console.WriteLine();

                switch (input)
                {
                  case ConsoleKey.R:
                        Display.DisplayInventoryMenu1();
                        Display.WaitForKeyPress();
                        break;
                  case ConsoleKey.M:
                        Display.DisplayInventoryMenu2();
                        Display.WaitForKeyPress();
                        break;
                  case ConsoleKey.E:
                        Map.ShowTerrainAtCurrentPosition(); 
                        break;
                  case ConsoleKey.Escape:
                        ProcessDisplayMenuInput();
                        continueInventory = false;
                        break;
                  case ConsoleKey.Q:
                        continueInventory = false;
                        break;
                  default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);break;
                }
            }
        }
    }
}