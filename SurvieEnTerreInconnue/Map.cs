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
      
        //gameDuration = gameEnd - gameStart;
        public static int playerPositionX = 0;
        public static int playerPositionY = 0;
        public static int[,] mapGrid = new int[10, 10];
        public static bool[,] discovered = new bool[10, 10];
        public static Random randomGenerator = new Random();
        public static string[] resourceNames = {"Fer", "Bois", "Silex", "Argile", "Herbes", "Sable",
                                "Feu", "Haches", "Vitre", "Planche", "Briques", "Isolants", "Maisons", "Fruits", "Eau" , "Gibier", "Poisson" };
        public static int numberOfTripsRemaining = 200;
        public static int playerEnergy = 100;

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

        //Méthode qui compte le nombre de voyages restants et diminue l'énergie du joueur à chaque déplacements
        public static bool ManageNumberOfTrip()
        {
            numberOfTripsRemaining--;
            playerEnergy--;

            if (playerEnergy <= 0)
            {
                Console.Clear();
                Display.DisplayLoseMessage();
                return false;
            }

            if (numberOfTripsRemaining <= 0)
            {
                Console.Clear();
                Display.DisplayLoseMessage();
                return false;
            }
            return true;
        }
        public static void GenerateMap()
        {
            for (int i = 0; i < mapGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mapGrid.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        mapGrid[i, j] = 0; //Base
                        discovered[i, j] = true; 
                    }
                    else
                    {
                        mapGrid[i, j] = randomGenerator.Next(1, 7); //Autres types de terrain
                    }
                }
            }
        }
        /*
        //Méthode affichant la grille du jeu
        public static void DisplayGridMap()
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;

            //Boucles pour les lignes (y)
            for (int i = 0; i < mapGrid.GetLength(0); i++)
            {
                // Boucles pour les colonnes (x)
                for (int j = 0; j < mapGrid.GetLength(1); j++)
                {
                    // Si position du joueur
                    if (playerPositionX == j && playerPositionY == i)
                    {
                        int terrain = mapGrid[i, j];
                        SetTerrainColor(terrain);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  👤  ");    
                        Console.ResetColor();
                    }
                    //Sinon si découvert
                    else if (discovered[i, j])
                    {
                        int terrain = mapGrid[i, j];
                        SetTerrainColor(terrain);

                        Console.Write("  ");
                        SetTerrainEmoji(terrain);
                        Console.Write("  ");

                        Console.ResetColor();
                    }
                    // Sinon case noire
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("      ");      
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }
        */

        public static void DisplayGridMap()
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;

            //Boucles pour les lignes (y)
            for (int i = 0; i < mapGrid.GetLength(0); i++)
            {
                // Boucles pour les colonnes (x)
                for (int j = 0; j < mapGrid.GetLength(1); j++)
                {
                    // Si position du joueur
                    if (playerPositionX == j && playerPositionY == i)
                    {
                        int terrain = mapGrid[i, j];
                        SetTerrainColor(terrain);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  👤  ");
                        Console.ResetColor();
                    }
                    //Sinon si découvert
                    else if (discovered[i, j])
                    {
                        int terrain = mapGrid[i, j];
                        SetTerrainColor(terrain);

                        Console.Write("  ");
                        SetTerrainEmoji(terrain);
                        Console.Write("  ");

                        Console.ResetColor();
                    }
                    // Sinon case noire
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("      ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }

        //Méthode qui va rétablir toutes les données du joueur à zéro
        public static void ResetGame()
        {
            playerPositionX = 0;
            playerPositionY = 0;
            playerEnergy = 100;

            numberOfTripsRemaining = 200;

            for (int i = 0; i < resourceAmounts.Length; i++)
            {
                resourceAmounts[i] = 0;
            }

            for (int i = 0; i < discovered.GetLength(0); i++)
            {
                for (int j = 0; j < discovered.GetLength(1); j++)
                {
                    discovered[i, j] = false;
                }
            }

            discovered[0, 0] = true;

            GenerateMap();
        }

        public static void StartNewGame()
        {
            Map.ResetGame();
        }

        //Méthode qui attribue une couleur à un terrain spécifique
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
        public static void SetTerrainEmoji(int terrain)
        {
            Console.OutputEncoding = Encoding.UTF8;
            switch (terrain)
            {
                case 0: // Base
                    Console.Write("🏠");
                    break;
                case 1: // Forêt
                    Console.Write("🌲");
                    break;
                case 2: // Prairie
                    Console.Write("🌿");
                    break;
                case 3: // Désert
                    Console.Write("🏜️");
                    break;
                case 4: // Rivière
                    Console.Write("🌊");
                    break;
                case 5: // Marais
                    Console.Write("🌫️"); 
                    break;
                case 6: // Montagne
                    Console.Write("⛰️");
                    break;
                default:
                    Console.Write("");
                    break;
            }
        }
       // ui collecte les matériaux de chaque terrain en fonction de leurs probabilités
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
                    break;
            }
        }
        //Probabilité de collecte de ressources dans le désert
        public static void ProbabilityDiscoveryInDesert()
        {
            int roll = randomGenerator.Next(0, 100);

            if (roll < 10) 
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

        //Probabilité de collecte de ressources dans la forêt
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

        //Probabilité de collecte de ressources dans le marais
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

        //Probabilité de collecte de ressources dans la rivière
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

        //Probabilité de collecte de ressources dans la prairie
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

        //Probabilité de collecte de ressources dans la montagne
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

       //Méthode qui attribue un terrain à une position de manière aléatoire
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
      
        //Méthode qui va afficher le terrain en fonction de la position du joueur
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

        //Méthode qui va afficher le menu de chaque terrain
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
            Console.WriteLine("[M]anger un fruits");
            Console.WriteLine("[B]oire de l'eau");
            Console.WriteLine("[ESC]Retour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Display.AnimateText("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }
        //Méthode qui affiche la forêt 
        public static ConsoleKey DisplayForest()
        {
            Console.Clear();
            Display.DisplayForestPosition();
            /*
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            Display.DisplayForest();*/
            return DisplayTerrainMenu("dans la forêt");
        }

        //Méthode qui affiche la prairie
        public static ConsoleKey DisplayPrairie()
        {
            Console.Clear();
            Display.DisplayPrairiePosition();
            /*
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            Display.DisplayPrairie();*/
            return DisplayTerrainMenu("dans la prairie");
        }

        //Méthode qui affiche le désert
        public static ConsoleKey DisplayDesert()
        {
            Console.Clear();
            Display.DisplayDesertPosition();
            /*
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            Display.DisplayDesert();
            */
            return DisplayTerrainMenu("dans le désert");
        }

        //Méthode qui affiche la rivière
        public static ConsoleKey DisplayRiver()
        {
            Console.Clear();
            Display.DisplayRiverPosition();

            /*
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            Display.DisplayRiver();
            */
            return DisplayTerrainMenu("près de la rivière");
        }

        //Méthode qui affiche le marais
        public static ConsoleKey DisplaySwamp()
        {
            Console.Clear();
            Display.DisplaySwampPosition();

            /*
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            Display.DisplaySwamp();
            */
            return DisplayTerrainMenu("dans le marais");
        }

        //Méthode qui affiche la montagne
        public static ConsoleKey DisplayMountain()
        {
            Console.Clear();
            Display.DisplayMountainPosition();

            /*
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            Display.DisplayMountain();*/
            return DisplayTerrainMenu("dans la montagne");
        }
        //Méthode qui affiche le terrain de base, ainsi que son mene
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
            Console.WriteLine("[ESC]Retour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Display.AnimateText("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        //Méthode qui va traiter les choix effectuer par l'utilisateur dans le terrain de base
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

                    case ConsoleKey.Escape:
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

        //Méthode qui affiche la carte, ainsi que les différents directions pour explorer la carte et quelques informations de bases ( position du joueur, terrain actuel et nombres de voyages restants)
        public static ConsoleKey DisplayDirection()
        {
           
            Console.Clear();
            DisplayGridMap();
            Console.WriteLine();
            Console.WriteLine($"Position du joueur: ({playerPositionX}, {playerPositionY}) - {GetCurrentTerrain()}");
            Console.WriteLine($"Nombre de déplacement(s) restant(s) : {numberOfTripsRemaining}");
            Display.DisplayEnergyBar();
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Veuillez sélectionner une option :");
            Console.WriteLine();
            Console.WriteLine("[N]ord : Vous vous déplacez vers le haut");
            Console.WriteLine("[O]uest : Vous vous déplacez vers la gauche");
            Console.WriteLine("[S]ud : Vous vous déplacez vers le bas");
            Console.WriteLine("[E]st : Vous vous déplacez vers la droite");
            Console.WriteLine("[ENTER]Intéragir avec le terrain actuel");
            Console.WriteLine("[ESC] Retour au menu principal");
            Console.WriteLine("[Q]uitter : Quitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        //Méthode qui va afficher les limites de chaque coté de la carte
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

        //Méthode qui traite les choix effectuer par l'utilisateur dans le DisplayDirection
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
                            exploring = ManageNumberOfTrip();
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
                            exploring = ManageNumberOfTrip();
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
                            exploring = ManageNumberOfTrip();
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
                            exploring = ManageNumberOfTrip();
                            discovered[playerPositionY, playerPositionX] = true;
                        }
                        else
                        {
                            ShowBoundaryMessage("Est");
                        }
                        break;

                    case ConsoleKey.Enter:
                        ShowTerrainAtCurrentPosition();
                        exploring = false;
                        break;

                    case ConsoleKey.Escape:
                        exploring = false;
                        Console.Clear();
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

       
        //Méthode qui passe en paramètre une méthode  du type DisplayTerrain (par exemple DisplayForest) et qui traite les choix effectuer par l'utilisateur dans chaque terrain
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
                        CollectMaterials();
                        Console.ReadKey();
                        break;

                    case ConsoleKey.M:
                        Crafting.EatFruits();
                        Menu.WaitForKeyPress();  
                        break;

                    case ConsoleKey.B:
                        Crafting.DrinkWater();
                        Menu.WaitForKeyPress();  
                        break;
                    case ConsoleKey.Escape:
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
        //Ces méthodes retournent le choix de l'utilsateur en fonction de ProcessTerrainInput 
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