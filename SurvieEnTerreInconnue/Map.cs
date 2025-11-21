using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvieEnTerreInconnue
{
    internal class Map
    {
        public static double probabilyDiscovery;
        public static int playerPositionX = 0;
        public static int playerPositionY = 0;
        public static int[,] mapGrid = new int[10, 10];
        public static bool[,] discovered = new bool[10, 10];
        public static Random randomGenerator = new Random();
        public static string[] resourceNames = {"Fer", "Bois", "Silex", "Argile", "Herbes", "Sable",
                                "Feu", "Haches", "Vitre", "Planche", "Briques", "Isolants", "Maisons" };
        public static int[] resourceAmounts = {0, 0, 0, 0, 0, 0,  0, 0, 0, 0, 0, 0, 0 };

        public static void GenerateMap()
        {
            for (int i = 0; i < mapGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mapGrid.GetLength(1); j++)
                {
                    // Si la postion est aux coordonnées (0.0) alors nous sommes sur le terrain de base
                    if (i == 0 && j == 0)
                    {
                        mapGrid[i, j] = 0; // Base
                        discovered[i, j] = true;
                    }
                    // Sinon on génère un terrain aléatoirement
                    else
                    {
                        mapGrid[i, j] = randomGenerator.Next(1, 7);
                    }
                }
            }
        }

        // Afficher la carte avec la bonne couleur de fond
        public static void DisplayGridMap()
        {
            Console.Clear();
            for (int i = 0; i < mapGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mapGrid.GetLength(1); j++)
                {
                    // Si c'est la position du joueur
                    if (playerPositionX == j && playerPositionY == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" )( ");
                        Console.ResetColor();
                    }
                    // Si découvert
                    else if (discovered[i, j])
                    {
                        int terrain = mapGrid[i, j];
                        SetTerrainColor(terrain);
                        Console.Write("    ");
                        Console.ResetColor();
                    }
                    // Non découvert
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("    ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }

        // On va attribuer une couleur de fond unique à chaque terrain
        public static void SetTerrainColor(int terrain)
        {
            switch (terrain)
            {
                case 0: // Base
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 1: // Forêt
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break; 
                case 2: // Prairie
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 3: // Désert
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 4: // Rivière
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 5: // Marais
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 6: // Montagne
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
        }
        // On coolecte le matériels en fonction
        public static void CollectMaterials()
        {
            string terrain = GetCurrentTerrain();

            switch (terrain)
            {
                case "Base":
                    Console.WriteLine("Vous ne pouvez rien collecter ici.");
                    break;

                case "Forêt":
                    Console.WriteLine("Vous collectez du Bois !");
                    resourceAmounts[1]++; 
                    break;

                case "Prairie":
                    Console.WriteLine("Vous collectez de l'Herbe !");
                    resourceAmounts[4]++; 
                    break;

                case "Désert":
                    Console.WriteLine("Vous collectez du Sable !");
                    resourceAmounts[5]++;
                    break;

                case "Rivière":
                    Console.WriteLine("Vous collectez du Silex !");
                    resourceAmounts[2]++; 
                    break;

                case "Marais":
                    Console.WriteLine("Vous collectez de l'Argile !");
                    resourceAmounts[3]++; 
                    break;

                case "Montagne":
                    Console.WriteLine("Vous collectez du Fer !");
                    resourceAmounts[0]++;
                    break;

                default:
                    Console.WriteLine("Terrain inconnu, rien à collecter.");
                    break;
            }
        }

        public static void ProbabilityDiscoveryInDesert()
        {
            probabilyDiscovery = randomGenerator.Next(1, 100);

            if (probabilyDiscovery < 1)
            {
                Console.WriteLine("Vous avez collecter de l'eau !");
            }
            else if (probabilyDiscovery < 90) 
            {
                Console.WriteLine("Vous avez collecter du sable");
            }
            else
            {
                Console.WriteLine();
            }
        }
        public static void ProbabilityDiscoveryInForest()
        {
            probabilyDiscovery = randomGenerator.Next(1, 100);

            if (probabilyDiscovery < 5)
            {
                probabilyDiscovery = randomGenerator.Next(0, 2);

                switch(probabilyDiscovery)
                {
                    case 0:
                        Console.WriteLine("Vous avez collecter de l'eau");
                        break;
                    case 1:
                        Console.WriteLine("Vous avez collecter des fruits");
                        break;
                    default:
                        break;
                }
            }
            else if (probabilyDiscovery < 10) 
            {
                Console.WriteLine("Vous avez collecter dU gibier");
            }
            else
            {
                Console.WriteLine("Vous avez collecter du bois");
            }
        }
        public static void ProbabilityDiscoveryInSwamp()
        {
            probabilyDiscovery = randomGenerator.Next(1, 100);

            if (probabilyDiscovery < 5)
            {
                Console.WriteLine("Vous avez collecter du poisson");
            }
            else if (probabilyDiscovery < 45) 
            {
                Console.WriteLine("Vous avez collecter de l'argile");
            }
            else
            {
                Console.WriteLine("Vous avez collecter de l'eau !");
            }
        }
        public static void ProbabilityDiscoveryInRiver()
        {
            probabilyDiscovery = randomGenerator.Next(1, 100);

            if (probabilyDiscovery < 20)
            {
                Console.WriteLine("Vous avez collecter du poisson");
            }
            else if (probabilyDiscovery < 30) 
            {
                Console.WriteLine("Vous avez collecter de l'eau");
            }
            else
            {
                Console.WriteLine("Vous avez collecter du silex");
            }
        }
        public static void ProbabilityDiscoveryInPrairie()
        {
            probabilyDiscovery = randomGenerator.Next(1, 100);

            if (probabilyDiscovery < 20)
            {
                Console.WriteLine("Vous avez collecter du poisson");
            }
            else
            {
                Console.WriteLine("Vous avez collecter du silex");
            }
        }

        public static string GetCurrentTerrain()
        {
            int terrain = mapGrid[playerPositionY, playerPositionX];

            switch (terrain)
            {
                case 0: 
                    return "Base";
                case 1:
                    return "Forêt";
                case 2:
                    return "Prairie";
                case 3: 
                    return "Désert";
                case 4: 
                    return "Rivière";
                case 5:
                    return "Marais";
                case 6:
                    return "Montagne";
                default: 
                    return "";
            }
        }

        public static void ShowTerrainAtCurrentPosition()
        {
            discovered[playerPositionY, playerPositionX] = true;
            string terrain = GetCurrentTerrain();

            switch (terrain)
            {
                case "Base":
                    ProcessDisplayBaseInput();
                    break;
                case "Forêt":
                    ProcessDisplayForestInput();
                    break;
                case "Prairie":
                    ProcessDisplayPrairieInput();
                    break;
                case "Désert":
                    ProcessDisplayDesertInput();
                    break;
                case "Rivière":
                    ProcessDisplayRiverInput();
                    break;
                case "Marais":
                    ProcessDisplaySwampInput();
                    break;
                case "Montagne":
                    ProcessDisplayMountainInput();
                    break;
            }
        }

        public static ConsoleKey DisplayTerrainMenu(string terrainName)
        {
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.WriteLine();
            Display.AnimateText($"Vous êtes actuellement {terrainName}");
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

        public static ConsoleKey DisplayBase()
        {
            Console.Clear();
            Display.DisplayBasePosition();
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Display.AnimateText("Vous êtes actuellement sur le terrain de base");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :\n");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.ResetColor();
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
            Console.ResetColor();
            bool stayAtBase = true;

            while (stayAtBase)
            {
                ConsoleKey input = DisplayBase();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        stayAtBase = false;
                        break;

                    case ConsoleKey.A:
                        Menu.ProcessInventoryInput();
                        break;

                    case ConsoleKey.F:
                        Menu.ProcessDisplayManufacturingInput();
                        break;

                    case ConsoleKey.R:
                        stayAtBase = false;
                        Menu.ProcessDisplayMenuInput();
                        break;

                    case ConsoleKey.Q:
                        Menu.ProcessDisplayLeaveMessageInput();
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
            DisplayGridMap();
            Console.WriteLine();
            Console.WriteLine($"Position du joueur: ({playerPositionX}, {playerPositionY}) - {GetCurrentTerrain()}");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Veuillez sélectionner une option :");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[N]ord : Vous vous déplacez vers le haut");
            Console.WriteLine("[O]uest : Vous vous déplacez vers la gauche");
            Console.WriteLine("[S]ud : Vous vous déplacez vers le bas");
            Console.WriteLine("[E]st : Vous vous déplacez vers la droite");
            Console.WriteLine("[I]nteragir avec le terrain actuel");
            Console.WriteLine("[M]enu : Retour au menu principal");
            Console.WriteLine("[Q]uitter : Quitter le jeu");
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
                    case ConsoleKey.UpArrow:
                        if (playerPositionY > 0) 
                        {
                            playerPositionY--; 
                            discovered[playerPositionY, playerPositionX] = true;
                        }
                        else
                        {
                            Console.Clear();
                            Display.AnimateText("Vous ne pouvez pas aller plus au Nord !");
                            Thread.Sleep(1500);
                        }
                        break;


                    case ConsoleKey.O:
                    case ConsoleKey.LeftArrow:
                        if (playerPositionX > 0)
                        {
                            playerPositionX--;
                            discovered[playerPositionY, playerPositionX] = true;
                        }
                        else
                        {
                            Console.Clear();
                            Display.AnimateText("Vous ne pouvez pas aller plus à l'Ouest !");
                            Thread.Sleep(1500);
                        }
                        break;

                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        if (playerPositionY < mapGrid.GetLength(0) - 1) 
                        {
                            playerPositionY++; 
                            discovered[playerPositionY, playerPositionX] = true;
                        }
                        else
                        {
                            Console.Clear();
                            Display.AnimateText("Vous ne pouvez pas aller plus au Sud !");
                            Thread.Sleep(1500);
                        }
                        break;
                    case ConsoleKey.E:
                    case ConsoleKey.RightArrow:
                        if (playerPositionX < mapGrid.GetLength(1) - 1)
                        {
                            playerPositionX++;
                            discovered[playerPositionY, playerPositionX] = true;
                        }
                        else
                        {
                            Console.Clear();
                            Display.AnimateText("Vous ne pouvez pas aller plus à l'Est !");
                            Thread.Sleep(1500);
                        }
                        break;

                    case ConsoleKey.I:
                        ShowTerrainAtCurrentPosition();
                        exploring = false;
                        break;

                    case ConsoleKey.M:
                        exploring = false;
                        Console.Clear();
                        Display.AnimateText("Retour au menu principal...");
                        Thread.Sleep(1500);
                        Menu.ProcessDisplayMenuInput();
                        break;

                    case ConsoleKey.Q:
                        exploring = false;
                        Console.Clear();
                        Menu.ProcessDisplayLeaveMessageInput();
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
            return DisplayTerrainMenu("dans la forêt");
        }

        public static ConsoleKey DisplayPrairie()
        {
            Console.Clear();
            Display.DisplayPrairiePosition();
            return DisplayTerrainMenu("dans la prairie");
        }

        public static ConsoleKey DisplayDesert()
        {
            Console.Clear();
            Display.DisplayDesertPosition();
            return DisplayTerrainMenu("dans le désert");
        }

        public static ConsoleKey DisplayRiver()
        {
            Console.Clear();
            Display.DisplayRiverPosition();
            return DisplayTerrainMenu("près de la rivière");
        }

        public static ConsoleKey DisplaySwamp()
        {
            Console.Clear();
            Display.DisplaySwampPosition();
            return DisplayTerrainMenu("dans le marais");
        }

        public static ConsoleKey DisplayMountain()
        {
            Console.Clear();
            Display.DisplayMountainPosition();
            return DisplayTerrainMenu("dans la montagne");
        }
      //Une fonction qui passe en paramètres une fonction entière
        public static bool ProcessTerrainInput(Func<ConsoleKey> displayFunction)
        {
            bool stayInTerrain = true;

            while (stayInTerrain)
            {
                ConsoleKey input = displayFunction();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        stayInTerrain = false;
                        break;

                    case ConsoleKey.A:
                        Menu.ProcessInventoryInput();
                        break;

                    case ConsoleKey.C:
                        Map.CollectMaterials();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;


                    case ConsoleKey.R:
                        stayInTerrain = false;
                        Menu.ProcessDisplayMenuInput();
                        break;

                    case ConsoleKey.Q:
                        Menu.ProcessDisplayLeaveMessageInput();
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

        public static bool ProcessDisplayForestInput()
        {
            return ProcessTerrainInput(DisplayForest);
        }

        public static bool ProcessDisplayPrairieInput()
        {
            return ProcessTerrainInput(DisplayPrairie);
        }

        public static bool ProcessDisplayDesertInput()
        {
            return ProcessTerrainInput(DisplayDesert);
        }

        public static bool ProcessDisplayRiverInput()
        {
            return ProcessTerrainInput(DisplayRiver);
        }

        public static bool ProcessDisplaySwampInput()
        {
            return ProcessTerrainInput(DisplaySwamp);
        }

        public static bool ProcessDisplayMountainInput()
        {
            return ProcessTerrainInput(DisplayMountain);
        }
    }
}