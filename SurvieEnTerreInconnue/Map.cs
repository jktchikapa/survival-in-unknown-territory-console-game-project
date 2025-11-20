using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvieEnTerreInconnue
{
    internal class Map
    {
        public static ConsoleKey DisplayBase()
        {
            Console.Clear();
            Display.DisplayBasePosition();
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement sur le terrain de base");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[F]abriquer des matériaux");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayBaseInput()
        {
            bool stayAtBase = true;

            while (stayAtBase)
            {
                ConsoleKey input = DisplayBase();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;

                    case ConsoleKey.F:
                        break;

                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }

        public static ConsoleKey DisplayDirection()
        {
            Console.Clear();
            Display.AnimateText("Dans quelle direction voulez-vous aller ?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[N]ord : Vous vous déplacez vers le haut");
            Console.WriteLine("[O]uest : Vous vous déplacez vers la gauche");
            Console.WriteLine("[S]ud : Vous vous déplacez vers le bas");
            Console.WriteLine("[E]st : Vous vous déplacez vers la droite");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static void ProcessExplorationInput()
        {
            bool exploring = true;

            while (exploring)
            {
                ConsoleKey input = DisplayDirection();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.N:
                        Console.Clear();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.O:
                        Console.Clear();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.S:
                        Console.Clear();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.E:
                        Console.Clear();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Display.AnimateText("Direction invalide. Veuillez réessayer.");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }

        public static ConsoleKey DisplayForest()
        {
            Console.Clear();
            Display.DisplayForestPosition();
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement dans la forêt");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayForestInput()
        {
            bool stayInForest = true;

            while (stayInForest)
            {
                ConsoleKey input = DisplayForest();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;

                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }
        public static ConsoleKey DisplayPrairie()
        {
            Console.Clear();
            Display.DisplayPrairiePosition();
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement dans la prairie");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayPrairieInput()
        {
            bool stayInPrairie = true;

            while (stayInPrairie)
            {
                ConsoleKey input = DisplayPrairie();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;

                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }
    
        public static ConsoleKey DisplayDesert()
        {
            Console.Clear();
            Display.DisplayDesertPosition();
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement dans le désert");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayDesertInput()
        {
            bool stayInDesert = true;

            while (stayInDesert)
            {
                ConsoleKey input = DisplayDesert();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;

                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }

        public static ConsoleKey DisplayRiver()
        {
            Console.Clear();
            Display.DisplayRiverPosition();
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement près de la rivière");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayRiverInput()
        {
            bool stayAtRiver = true;

            while (stayAtRiver)
            {
                ConsoleKey input = DisplayRiver();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;

                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }

        public static ConsoleKey DisplaySwamp()
        {
            Console.Clear();
            Display.DisplaySwampPosition();
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement dans le marais");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplaySwampInput()
        {
            bool stayInSwamp = true;

            while (stayInSwamp)
            {
                ConsoleKey input = DisplaySwamp();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;

                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }

        public static ConsoleKey DisplayMountain()
        {
            Console.Clear();
            Display.DisplayMountainPosition();
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement dans la montagne");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayMountainInput()
        {
            bool stayInMountain = true;

            while (stayInMountain)
            {
                ConsoleKey input = DisplayMountain();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;

                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }
    }
}