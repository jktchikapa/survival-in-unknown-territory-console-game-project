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
        public static bool isFirstGame = true;
        // Méthode qui affiche un message et attend que l'utilisateur appuie sur une touche
        public static void WaitForKeyPress(string message = "\nAppuyez sur une touche pour continuer...")
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        //Méthode qui affiche le menu principal
        public static ConsoleKey DisplayMenu()
        {
            Console.Clear();
            Display.DisplayPrincipalMenu();
            Console.WriteLine();
            Console.WriteLine("Veuillez sélectionner une action :");
            Console.WriteLine("[D]émarer une nouvelle partie");
            Console.WriteLine("[C]hargé une partie");
            Console.WriteLine("[S]auvegarder une partie");
            Console.WriteLine("[A]uteurs");
            Console.WriteLine("[R]ègles du jeu");
            Console.WriteLine("[M]ise en contexte");
            Console.WriteLine("[Q]uitter");

            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        // La méthode traite les choix qui on été effectuer par l'utilisateur dans la méthode DisplayMenu
        public static void ProcessDisplayMenuInput()
        {
            bool continueGame = true;

            while (continueGame)
            {
                ConsoleKey input = DisplayMenu();

                switch (input)
                {
                    case ConsoleKey.D:
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
                        DisplayProgrammersCredits();
                        WaitForKeyPress("\n\nAppuyez sur une touche pour retourner au menu...");
                        break;

                    case ConsoleKey.R:
                        DisplayGameRules();
                        WaitForKeyPress("\nAppuyez sur une touche pour retourner au menu principal...");
                        break;

                    case ConsoleKey.M:
                        DisplayGameHistory();
                        WaitForKeyPress("\nAppuyez sur une touche pour retourner au menu principal...");
                        break;

                    case ConsoleKey.Q:
                        continueGame = ProcessDisplayLeaveMessageInput();
                        break;
                    case ConsoleKey.Enter:
                        Map.ShowTerrainAtCurrentPosition();
                        Thread.Sleep(1000);
                        break;

                    default:
                        Display.AnimateText("Choix invalide. Veuillez réessayer.", Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        /*
          switch (input)
                {
                    case ConsoleKey.D:
                        
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
                        DisplayProgrammersCredits();
                        WaitForKeyPress("\n\nAppuyez sur une touche pour retourner au menu...");
                        break;

                    case ConsoleKey.R:
                        DisplayGameRules();
                        WaitForKeyPress("\nAppuyez sur une touche pour retourner au menu principal...");
                        break;

                    case ConsoleKey.M:
                        DisplayGameHistory();
                        WaitForKeyPress("\nAppuyez sur une touche pour retourner au menu principal...");
                        break;

                    case ConsoleKey.Q:
                        continueGame = ProcessDisplayLeaveMessageInput();
                        break;

                    default:
                        Display.AnimateText("Choix invalide. Veuillez réessayer.", Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        break;
                }
         */
        // Méthode qui affiche les crédits du jeu
        public static void DisplayProgrammersCredits()
        {
            Display.DisplayCreditMessage();

            Display.AnimateText("\nCe jeu a été développé par :", ConsoleColor.White, 50);
            Display.AnimateText("\n - Romuald Arnaud", ConsoleColor.White, 50);
            Display.AnimateText("\n - Jessica Karelle\n", ConsoleColor.White, 50);
            Display.AnimateText("\n Nos amélioratrions :\n", ConsoleColor.White, 50);
            Display.AnimateText("- Plusieurs menus et interfaces pour l'utilisateur\n", ConsoleColor.White, 50);
            Display.AnimateText("- Système de probabilités de collecte de ressources\n", ConsoleColor.White, 50);
            Display.AnimateText("- Ajouts d'émojis significatifs pour chaque terrain\n", ConsoleColor.White, 50);
            Display.AnimateText("- Ajouts des choix Boire/Manger  \n", ConsoleColor.White, 50);
            Display.AnimateText("- Ajouts d'une barre d'énergie  \n", ConsoleColor.White, 50);
        }

        // Méthode qui affiche le message de fin du jeu, on valide si l'utilisateur voulait vraiment quitter la partie 
        public static ConsoleKey DisplayLeaveMessage()
        {
            Console.Clear();
            Display.AnimateText("Êtes vous sûr de vouloir quitter la partie ?");
            Console.WriteLine();
            Console.WriteLine("[O]ui, je souhaite quitter la partie");
            Console.WriteLine("[N]on, je ne souhaite plus quitter la partie");
            Console.WriteLine("[S]auvegarder ma progression et quitter");
            Console.WriteLine();
            Console.Write("Votre choix : ");
            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        //méthode qui va traiter le choix par rapport à ce qu'il aura choisi dans la méthode précédente
        public static bool ProcessDisplayLeaveMessageInput()
        {
            ConsoleKey input = DisplayLeaveMessage();

            switch (input)
            {
                case ConsoleKey.O:
                    Console.Clear();
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
                    Display.AnimateText("Choix invalide. Retour au menu...");
                    Thread.Sleep(1500);
                    ProcessDisplayMenuInput();
                    return true;
            }
        }

        //Méthode qui affiche le message d'aurevoir à l'utilisateur
        public static void DisplayGoodByeMessage()
        {
            Console.Clear();
            Console.WriteLine("\nAppuyez sur une touche pour fermer le jeu...");
            Console.ReadKey();
            Process.GetCurrentProcess().Kill();
        }
        //Méthode qui va afficher les régles du jeu
        public static void DisplayGameRules()
        {
            Console.Clear();
            Console.ReadKey();
        }
        //Méthode qui affiche l'histoire du jeu (une mise en contexte du jeu)
        public static void DisplayGameHistory()
        {
            Console.Clear();
            Display.DisplayPlaneCrash();
            Display.AnimateText("");
        }

        //Message qui s'affiche lorsque l'utilisateur réussi à construire une maison
        public static void DisplayEndMessage()
        {
            Display.DisplayHouse();
            Console.WriteLine("Félicitations. Vous avez réussi à construire une maison qui vous protègera du froid hivernale. Profitez bien");
            Process.GetCurrentProcess().Kill();
        }

        //Méthode qui affiche le menu de fabrication
        public static ConsoleKey DisplayManufacturingMenu()
        {
            Console.Clear();
            Display.DisplayManufacturingItems();
            Console.WriteLine();

            Console.WriteLine("\t********************************************************************************************************");

            Console.WriteLine($"\t* {"[F]eu".PadRight(10)}: Cette action nécessite du Bois et du Silex                                               *");
            Console.WriteLine($"\t* {"[H]ache".PadRight(10)}: Cette action nécessite du Bois et du Fer                                                 *");
            Console.WriteLine($"\t* {"[V]itre".PadRight(10)}: Cette action nécessite du Sable et du Feu                                                *");
            Console.WriteLine($"\t* {"[P]lanche".PadRight(10)}: Cette action nécessite du Bois ainsi qu'une Hache                                        *");
            Console.WriteLine($"\t* {"[B]rique".PadRight(10)}: Cette action nécessite du Feu et de l'Argile                                             *");
            Console.WriteLine($"\t* {"[I]solant".PadRight(10)}: Cette action nécessite 3x de l'Herbe                                                     *");
            Console.WriteLine($"\t* {"[M]aison".PadRight(10)}: Cette action nécessite 4x des Planches, 4x des Isolants, 4x des Briques et 2x des Vitres *");
            Console.WriteLine($"\t* {"[N]ouritture".PadRight(10)}: Cette action nécessite du Feu et du Bois                                               *");
            Console.WriteLine($"\t* {"[C]onsulter Inventaire".PadRight(10)}: Vous pouvez consulter votre inventaire                                       *");
            Console.WriteLine($"\t* {"[ESC]Retour au menu principal".PadRight(10)}                                                                        *");
            Console.WriteLine($"\t* {"[E]xplorer ou continuer d'explorer les territoires".PadRight(10)}                                                   *");
            Console.WriteLine($"\t* {"[Q]uitter le jeu".PadRight(10)}                                                                                     *");
            Console.WriteLine("\t********************************************************************************************************");
            Console.Write("\n\nVotre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static ConsoleKey DisplayCookingMenu()
        {
            Console.Clear();
            Display.DisplayCooking();
            Console.WriteLine();
            Console.WriteLine("Veuillez sélectionner l'aliments que vous souhaitez cuisiner :");
            Console.WriteLine("[P]oisson");
            Console.WriteLine("[G]ibier");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[E]xplorer ou continuer d'explorer les territoires");
            Console.WriteLine("[R]etour au menu de fabrication");
            Console.WriteLine("[ESC] Retour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.Write("\n\nVotre choix : ");

            ConsoleKeyInfo key = Console.ReadKey();

            return key.Key;
        }

        public static void ProcessCookingMenuInput()
        {
            bool continueCooking = true;

            while (continueCooking)
            {
                ConsoleKey input = DisplayCookingMenu();

                switch (input)
                {
                    case ConsoleKey.P:
                        Crafting.CookFish();
                        WaitForKeyPress();
                        break;

                    case ConsoleKey.G:
                        Crafting.CookMeat();
                        WaitForKeyPress();
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
                        Console.WriteLine("Appuyez sur la touche Entrez pour continuer votre partie ...");
                        Console.ReadKey();
                        continueCooking = false;
                        break;

                    case ConsoleKey.Q:
                        DisplayLeaveMessage();
                        continueCooking = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Action annulée.");
                        break;
                }
            }
        }

        //Méthode qui traite les choix effectuer par l'utilisateur dans le menu de fabrication
        public static bool ProcessDisplayManufacturingInput()
        {
            bool continueManufacturing = true;

            while (continueManufacturing)
            {
                ConsoleKey input = DisplayManufacturingMenu();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.F:
                        Console.Clear();
                        Crafting.BuildFire();
                        WaitForKeyPress();
                        break;

                    case ConsoleKey.H:
                        Console.Clear();
                        Crafting.BuildAxe();
                        WaitForKeyPress();
                        break;

                    case ConsoleKey.V:
                        Console.Clear();
                        Crafting.BuildGlass();
                        WaitForKeyPress();
                        break;

                    case ConsoleKey.P:
                        Console.Clear();
                        Crafting.BuildPlank();
                        WaitForKeyPress();
                        break;

                    case ConsoleKey.B:
                        Console.Clear();
                        Crafting.BuildBrick();
                        WaitForKeyPress();
                        break;

                    case ConsoleKey.I:
                        Console.Clear();
                        Crafting.BuildInsulator();
                        WaitForKeyPress();
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

                    case ConsoleKey.Q:
                        ProcessDisplayLeaveMessageInput();
                        return continueManufacturing = false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Action annulée");
                        break;
                }
            }

            return true;
        }

        //Méthode qui affiche le menu d'inventaire principal
        public static ConsoleKey DisplayInventoryPrincipalMenu()
        {
            Console.Clear();
            Display.DisplayInventoryItems();
            Console.WriteLine("\nBienvenue dans l'inventaire du jeu");
            Console.WriteLine("\nDans cette section, vous pouvez consulter toutes les ressources et matériaux à votre disposition");
            Console.WriteLine("Veuillez sélectionner une option :");
            Console.WriteLine("\n[R]essources : Consultez les ressources que vous possédez");
            Console.WriteLine("[M]atériaux : Consulter les matériaux que vous avez fabriqué");
            Console.WriteLine("[E]xplorer ou continuer d'explorer les territoires");
            Console.WriteLine("[ESC]Retour au menu principal");
            Console.WriteLine("[Q]uitter l'inventaire");
            Console.WriteLine();
            Display.AnimateText("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        //Méthode qui va traiter kes choix effectuer dans la méthode précédente
        public static void ProcessInventoryInput()
        {
            bool continueInventory = true;

            while (continueInventory)
            {
                ConsoleKey input = DisplayInventoryPrincipalMenu();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.R:
                        DisplayInventoryMenu1();
                        WaitForKeyPress();
                        break;

                    case ConsoleKey.M:
                        DisplayInventoryMenu2();
                        WaitForKeyPress();
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
                        Thread.Sleep(500);
                        break;
                }
            }
        }
        public static void DisplayInventoryMenu1()
        {

            Console.Clear();
            Display.DisplayInventoryItem1();
            Console.WriteLine();
            Console.WriteLine("\t\t*****************************************************");
            Console.WriteLine($"\t\t* {"Fer".PadRight(20)}: {$"{Map.resourceAmounts[0].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {"Bois".PadRight(20)}: {$"{Map.resourceAmounts[1].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {"Silex".PadRight(20)}: {$"{Map.resourceAmounts[2].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {"Argile".PadRight(20)}: {$"{Map.resourceAmounts[3].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {"Herbe".PadRight(20)}: {$"{Map.resourceAmounts[4].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {"Sable".PadRight(20)}: {$"{Map.resourceAmounts[5].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {"Fruits".PadRight(20)}: {$"{Map.resourceAmounts[13].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {"Eau".PadRight(20)}: {$"{Map.resourceAmounts[14].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {"Gibier".PadRight(20)}: {$"{Map.resourceAmounts[15].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {"Poisson".PadRight(20)}: {$"{Map.resourceAmounts[16].ToString()}".PadRight(28)}*");
            Console.WriteLine("\t\t*****************************************************");
        }
        //resourceNames[0] = Fer
        //resourceNames[1] = Bois
        //resourceNames[2] = Silex 
        //resourceNames[3] = Argile
        //resourceNames[4] = Herbe
        //resourceNames[5] = Sable
        //resourceNames[6] = Feu
        //resourceNames[7] = Haches
        //resourceNames[8] = Vitre
        //resourceNames[9] = Planche
        //resourceNames[10] = Briques
        //resourceNames[11] = Isolants
        //resourceNames[12] = Maison
        //resourceNames[13] = Fruits
        //resourceNames[14] = Eau
        //resourceNames[15] = Gibier
        //resourceNames[16] = Poisson
        //Méthode qui affiche le deuxième menu d'inventaire (matériaux)
        public static void DisplayInventoryMenu2()
        {
            Console.Clear();
            Display.DisplayInventoryItem2();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t*****************************************************");
            Console.WriteLine($"\t\t* {"Feu".PadRight(20)}:{$"{Map.resourceAmounts[6].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {"Haches".PadRight(20)}:{$"{Map.resourceAmounts[7].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {"Vitre".PadRight(20)}:{$"{Map.resourceAmounts[8].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {"Planche".PadRight(20)}:{$"{Map.resourceAmounts[9].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {"Briques".PadRight(20)}:{$"{Map.resourceAmounts[10].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {"Isolants".PadRight(20)}:{$"{Map.resourceAmounts[11].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {"Maison".PadRight(20)}:{$"{Map.resourceAmounts[12].ToString()}".PadRight(28)}  *");
            Console.WriteLine("\t\t*****************************************************");
        }

        //resourceNames[0] = Fer
        //resourceNames[1] = Bois
        //resourceNames[2] = Silex 
        //resourceNames[3] = Argile
        //resourceNames[4] = Herbe
        //resourceNames[5] = Sable
        //resourceNames[6] = Feu
        //resourceNames[7] = Haches
        //resourceNames[8] = Vitre
        //resourceNames[9] = Planche
        //resourceNames[10] = Briques
        //resourceNames[11] = Isolants
        //resourceNames[12] = Maison
        //resourceNames[13] = Fruits
        //resourceNames[14] = Eau
        //resourceNames[15] = Gibier
        //resourceNames[16] = Poisson
        //Méthode qui affiche le premier menu d'inventaire (ressources)
    }
}