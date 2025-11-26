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
        public static int playerPositionX = 0;
        public static int playerPositionY = 0;
        public static int[,] mapGrid = new int[10, 10];
        public static bool[,] discovered = new bool[10, 10];
        public static Random randomGenerator = new Random();
        public static string[] resourceNames = {"Fer", "Bois", "Silex", "Argile", "Herbes", "Sable",
                                "Feu", "Haches", "Vitre", "Planche", "Briques", "Isolants", "Maisons", "Fruits", "Eau" , "Gibier", "Poisson" };
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

        public static int[] resourceAmounts = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static void GenerateMap()
        {
            for (int i = 0; i < mapGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mapGrid.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        mapGrid[i, j] = 0; //Base
                        discovered[i, j] = true; //Logiquement la base est deja découverte quand le jeu commençe
                    }
                    else
                    {
                        mapGrid[i, j] = randomGenerator.Next(1, 7); //Autres types de terrain
                    }
                }
            }
        }
        // Cette méthode affiche la grille du jeu, si on est à la position du joueur on affiche son symbole sinon si on mets la couleur attribuer à chaque terrain, sinon on affiche le terrain en noir (vide)
        public static void DisplayGridMap()
        {
            Console.Clear();
            for (int i = 0; i < mapGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mapGrid.GetLength(1); j++)
                {
                    if (playerPositionX == j && playerPositionY == i)
                    {
                        int terrain = mapGrid[i, j];
                        SetTerrainColor(terrain);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" )( ");
                        Console.ResetColor();
                    }
                    else if (discovered[i, j])
                    {
                        int terrain = mapGrid[i, j];
                        SetTerrainColor(terrain);
                        Console.Write("    ");
                        Console.ResetColor();
                    }
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
        // On va attriubuer à chaque terrain une couleur symbolique qui permettra de facilement l'identifier, par exemple la forêt c'est le vert
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
        // Cette fonction va collecter le matériel selon les probabilités de chance de collecte de chaque ressource (voir les probabilités de chaque terrain en dessous de cette méthode) 
        public static void CollectMaterials()
        {
            string terrain = GetCurrentTerrain();

            switch (terrain)
            {
                case "Base":
                    Console.WriteLine("Vous ne pouvez rien collecter ici.");
                    break;

                case "Forêt":
                    ProbabilityDiscoveryInForest();
                    break;

                case "Prairie":
                    ProbabilityDiscoveryInPrairie();
                    break;

                case "Désert":
                    ProbabilityDiscoveryInDesert();
                    break;

                case "Rivière":
                    ProbabilityDiscoveryInRiver();
                    break;

                case "Marais":
                    ProbabilityDiscoveryInSwamp();
                    break;

                case "Montagne":
                    ProbabilityDiscoveryInMountain();
                    break;

                default:
                    Console.WriteLine("Terrain inconnu, rien à collecter.");
                    break;
            }
        }
        // Probabilité  de découverte des ressources dans le désert
        public static void ProbabilityDiscoveryInDesert()
        {
            int roll = randomGenerator.Next(0, 100);

            if (roll < 1) 
            {
                Console.WriteLine("Vous avez collecté de l'eau !");
                resourceAmounts[14]++; 
            }
            else if (roll < 90) 
            {
                Console.WriteLine("Vous avez collecté du sable");
                resourceAmounts[5]++; 
            }
            else 
            {
                Console.WriteLine("Vous n'avez rien trouvé...");
            }
        }
        // Probabilité  de découverte des ressources dans la forêt
        public static void ProbabilityDiscoveryInForest()
        {
            int roll = randomGenerator.Next(0, 100);

            if (roll < 5)
            {
                int subChoice = randomGenerator.Next(0, 2);

                if (subChoice == 0)
                {
                    Console.WriteLine("Vous avez collecté de l'eau");
                    resourceAmounts[14]++; 
                }
                else
                {
                    Console.WriteLine("Vous avez collecté des fruits");
                    resourceAmounts[13]++; 
                }
            }
            else if (roll < 15) 
            {
                Console.WriteLine("Vous avez collecté du gibier");
                resourceAmounts[15]++; 
            }
            else 
            {
                Console.WriteLine("Vous avez collecté du bois");
                resourceAmounts[1]++;
            }
        }
        // Probabilité  de découverte des ressources dans le marais
        public static void ProbabilityDiscoveryInSwamp()
        {
            int roll = randomGenerator.Next(0, 100);

            if (roll < 5) 
            {
                Console.WriteLine("Vous avez collecté du poisson");
                resourceAmounts[15]++; 
            }
            else if (roll < 45) 
            {
                Console.WriteLine("Vous avez collecté de l'argile");
                resourceAmounts[3]++;
            }
            else 
            {
                Console.WriteLine("Vous avez collecté de l'eau !");
                resourceAmounts[14]++; 
            }
        }
        // Probabilité  de découverte des ressources dans la rivière
        public static void ProbabilityDiscoveryInRiver()
        {
            int roll = randomGenerator.Next(0, 100);

            if (roll < 20) 
            {
                Console.WriteLine("Vous avez collecté du poisson");
                resourceAmounts[15]++; 
            }
            else if (roll < 50) 
            {
                Console.WriteLine("Vous avez collecté de l'eau");
                resourceAmounts[14]++;
            }
            else 
            {
                Console.WriteLine("Vous avez collecté du silex");
                resourceAmounts[2]++; 
            }
        }
        // Probabilité  de découverte des ressources dans la prairie
        public static void ProbabilityDiscoveryInPrairie()
        {
            int roll = randomGenerator.Next(0, 100);

            if (roll < 30) 
            {
                Console.WriteLine("Vous avez collecté des fruits");
                resourceAmounts[13]++;
            }
            else 
            {
                Console.WriteLine("Vous avez collecté de l'herbe");
                resourceAmounts[4]++; 
            }
        }
        // Probabilité  de découverte des ressources dans la montagne
        public static void ProbabilityDiscoveryInMountain()
        {
            int roll = randomGenerator.Next(0, 100);

            if (roll < 2) 
            {
                Console.WriteLine("Vous avez collecté de l'argile");
                resourceAmounts[3]++;
            }
            else if (roll < 7) 
            {
                Console.WriteLine("Vous avez collecté de l'eau");
                resourceAmounts[14]++; 
            }
            else 
            {
                Console.WriteLine("Vous avez collecté du fer");
                resourceAmounts[0]++; 
            }
        }
        // Cette méthode trouve le terrain en fonction de la génération aléatoire d'un nombre (voir début de la class)
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
        // Cette méthode affiche le terrain en fonction de la position du joueur
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
            Console.WriteLine();
            Console.WriteLine($"Vous êtes actuellement {terrainName}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Display.AnimateText("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
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

        public static ConsoleKey DisplayBase()
        {
            Console.Clear();
            Display.DisplayBasePosition();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Vous êtes actuellement sur le terrain de base");
            Console.WriteLine("Veuillez sélectionner une action à effectuer :\n");
            Console.ResetColor();
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[F]abriquer des matériaux");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Display.AnimateText("Votre choix : ");

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

        public static void ShowBoundaryMessage(string direction)
        {
            string article;
            if (direction == "Ouest" || direction == "Est")
            {
                article = "à l'";
            }
            else
            {
                article = "au ";
            }
            Console.ForegroundColor = ConsoleColor.DarkRed; 
            Console.WriteLine($"\nVous ne pouvez pas aller plus {article}{direction} !");
            Console.ResetColor();
            Thread.Sleep(500);
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
                            ShowBoundaryMessage("Nord");
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
                            ShowBoundaryMessage("Ouest");
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
                            ShowBoundaryMessage("Sud");
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
                            ShowBoundaryMessage("Est");
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

       
        //on aurait pu faire cette méthode pour chaque terrain mais ça aurait été trop long dans notre code, j'ai trouvé comment passer une méthode en paramètre sur Stackoverflow pour optimiser notre code
        //On va passer en paramètre chaque méthode pour ne pas à avoir les mêmes choses pour chaque terrain, cette méthode va retourner l'action que l'utilisateur choisira
        public static bool ProcessTerrainInput(Func<ConsoleKey> displayFunction)
        {
            bool stayInTerrain = true;

            while (stayInTerrain)
            {
                //input sera la consoleKey qui sera retourner par chaque méthode par exemple dans le DisplayForest
                ConsoleKey input = displayFunction();
                Console.WriteLine();

                //En codant, je me suis rendu compte que ce menu était le même pour tout les terrains
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
                        CollectMaterials();
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
        //Ces méthodes vont retourner le choix de l'utilisateur
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