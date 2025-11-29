using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SurvieEnTerreInconnue
{
    internal class Menu
    {
        public static List<string> saveList = new List<string>();
        // Méthode qui affiche le menu principal du jeu
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
            Console.WriteLine("[Q]uitter");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }
        // La méthode traite les choix qui on été effectuer par l'utilisateur dans la méthode qui précède
        public static void ProcessDisplayMenuInput()
        {
            bool continueGame = true;

            while (continueGame)
            {
                ConsoleKey input = DisplayMenu();

                switch (input)
                {
                    case ConsoleKey.D:
                        Map.GenerateMap();
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
                        Console.WriteLine("\n\nAppuyez sur une touche pour retourner au menu...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Q:
                        continueGame = ProcessDisplayLeaveMessageInput();
                        break;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }
        // Méthode qui affiche les crédits du jeu
        public static void DisplayProgrammersCredits()
        {
            Display.DisplayCreditMessage();

            Display.AnimateText("\nCe jeu a été développé par :", ConsoleColor.White, 50);
            Display.AnimateText("\n - Romuald Arnaud", ConsoleColor.White, 50);
            Display.AnimateText("\n - Jessica Karelle\n", ConsoleColor.White, 50);
        }

        // Méthode qui affiche le message de fin du jeu, on rassure que l'utilisateur a choisi cette option parce qu'il le voulait et non par erreur
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
        // Cette méthode va traiter le choix par rapport à ce qu'il aura choisi dans la méthode précédente
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
                    return false;

                default:
                    Display.AnimateText("Choix invalide. Retour au menu...");
                    Thread.Sleep(1500);
                    ProcessDisplayMenuInput();
                    return true;
            }
        }

        // Si l'utilisateur a choisi "oui, je souhaite quitter la partie", on lui affiche un beau message d'aurevoir 
        public static void DisplayGoodByeMessage()
        {
            Display.AnimateText("Vous avez ainsi fait votre choix, nous espérons que le jeu vous aura plu.");
            Display.AnimateText("\n\nNous espérons vous revoir bientôt !");
            Console.WriteLine();
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
        // Cette méthode  permet de mettre en contexte le jeu, pour que l'utilisateur comprenne de quoi il s'agit dans ce jeu 
        public static void DisplayGameHistory()
        {
            Display.AnimateText("\t\t\t\tMise en contexte de l'histoire ...\t");
            Display.AnimateText("\n\tVous êtes le seul survivant à un crash d'avion");
            Thread.Sleep(500);
            Display.AnimateText("\n\tVous êtes sur une île abandonnée, aucun signe de vie aux alentours");
            Thread.Sleep(500);
            Display.AnimateText("\n\tL'hiver approche ...");
            Console.WriteLine();
            Thread.Sleep(500);
            Display.AnimateText("\n\tConstruisez-vous un abri au plus vite si vous souhaitez survivre ...");
        }
        // Cette méthode (même si c'est peu probable qu'un joueur arrive à la fin du jeu) affichera le message de victoire du jeu
        public static void DisplayEndMessage()
        {
            Display.DisplayHouse(); 
            Console.WriteLine("\nVous avez reussi à vous construire une maison  qui vous protègera du froid hivernal. Nous vous souhaitons bon courage pour la suite !");
        }
       
        // Cette méthode affiche le menu de fabrication du jeu
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
            Console.WriteLine($"\t* {"[N]ourriture".PadRight(10)}: Cette action nécessite du Feu et du Bois                                               *");
            Console.WriteLine($"\t* {"[C]onsulter Inventaire".PadRight(10)}: Vous pouvez consulter votre inventaire                                       *");
            Console.WriteLine($"\t* {"[ESC]Retour au menu principal".PadRight(10)}                                                                        *");
            Console.WriteLine($"\t* {"[E]xplorer ou continuer d'explorer les territoires".PadRight(10)}                                                   *");
            Console.WriteLine($"\t* {"[Q]uitter le jeu".PadRight(10)}                                                                                     *");
            Console.WriteLine("\t********************************************************************************************************");
            Console.Write("\n\nVotre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }
        // Cette méthode va traiter les choix effectuer dans la méthode d'affiche du menu de fabrication
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
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.H:
                        Console.Clear();
                        Crafting.BuildAxe();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.V:
                        Console.Clear();
                        Crafting.BuildGlass();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.P:
                        Console.Clear();
                        Crafting.BuildPlank();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.Clear();
                        Crafting.BuildBrick();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.I:
                        Console.Clear();
                        Crafting.BuildInsulator();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.M:
                        Console.Clear();
                        Crafting.BuildHouse();
                        Console.ReadKey();
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
                        return continueManufacturing= false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Action annulée. Retour au menu de fabrication...");
                        Thread.Sleep(1500);
                        break;
                }
            }

            return true;
        }
        // Cette méthode affiche le menu d'inventaire principal
        public static ConsoleKey DisplayInventoryPrincipalMenu()
        {
            Console.Clear();
            Display.DisplayInventoryItems();
            Console.WriteLine("\nBienvenue dans l'inventaire du jeu");
            Console.WriteLine("\nDans cette section, vous pouvez consulter toutes les ressources et matériaux à votre disposition");
            Console.WriteLine("Veuillez sélectionner une option :");
            Console.WriteLine("\n[R]essources : Consultez les ressources que vous possédez");
            Console.WriteLine("[M]atériaux : Consulter les matériaux que vous avez fabriqué");
            Console.WriteLine("[ESC]Retour au menu principal");
            Console.WriteLine("[Q]uitter l'inventaire");
            Console.WriteLine();
            Display.AnimateText("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }
        // Cette méthode va traiter les choix effectuer dans la méthode précédente
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
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.M:
                        DisplayInventoryMenu2();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
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
        // Si l'utilisateur a choisi R, on va afficher son inventaire de ressources
        public static void DisplayInventoryMenu1()
        {
            Console.Clear();
            Display.DisplayInventoryItem1();
            Console.WriteLine();
            Console.WriteLine("\t\t*****************************************************");
            Console.WriteLine($"\t\t{"Fer".PadRight(20)}: {Map.resourceAmounts[0]}");
            Console.WriteLine($"\t\t{"Bois".PadRight(20)}: {Map.resourceAmounts[1]}");
            Console.WriteLine($"\t\t{"Silex".PadRight(20)}: {Map.resourceAmounts[2]}");
            Console.WriteLine($"\t\t{"Argile".PadRight(20)}: {Map.resourceAmounts[3]}");
            Console.WriteLine($"\t\t{"Herbe".PadRight(20)}: {Map.resourceAmounts[4]}");
            Console.WriteLine($"\t\t{"Sable".PadRight(20)}: {Map.resourceAmounts[5]}");
            Console.WriteLine($"\t\t{"Fruits".PadRight(20)}: {Map.resourceAmounts[13]}");
            Console.WriteLine($"\t\t{"Eau".PadRight(20)}: {Map.resourceAmounts[14]}");
            Console.WriteLine($"\t\t{"Gibier".PadRight(20)}: {Map.resourceAmounts[15]}");
            Console.WriteLine($"\t\t{"Poisson".PadRight(20)}: {Map.resourceAmounts[16]}");
            Console.WriteLine("\t\t*****************************************************");
        }
        //Si l'utilisateur a choisi M, on va afficher son inventaire de matériaux
        public static void DisplayInventoryMenu2()
        {
            Console.Clear();
            Display.DisplayInventoryItem2();
            Console.WriteLine();

            Console.WriteLine("\t\t*****************************************************");

            Console.WriteLine($"\t\t{"Feu".PadRight(20)}: {Map.resourceAmounts[6]}");
            Console.WriteLine($"\t\t{"Hache".PadRight(20)}: {Map.resourceAmounts[7]}");
            Console.WriteLine($"\t\t{"Vitre".PadRight(20)}: {Map.resourceAmounts[8]}");
            Console.WriteLine($"\t\t{"Planche".PadRight(20)}: {Map.resourceAmounts[9]}");
            Console.WriteLine($"\t\t{"Brique".PadRight(20)}: {Map.resourceAmounts[10]}");
            Console.WriteLine($"\t\t{"Isolant".PadRight(20)}: {Map.resourceAmounts[11]}");
            Console.WriteLine($"\t\t{"Maison".PadRight(20)}: {Map.resourceAmounts[12]}");

            Console.WriteLine("\t\t*****************************************************");
        }
    }
}
