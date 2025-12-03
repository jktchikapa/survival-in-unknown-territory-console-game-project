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
        public static int numberOfTripsRemaining = 200;
        public static int playerEnergy = 100;
        public static int[] resourceAmounts = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static bool hasStartedGame = false;

        /// <summary>
        /// Méthode qui diminue le nombres de déplacements restants du joueur son énergie
        /// </summary>
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

        /// <summary>
        /// Méthode qui génère la carte du jeu
        /// </summary>
        public static void GenerateMap()
        {
            for (int i = 0; i < mapGrid.GetLength(0); i++)
            {
                for (int j = 0; j < mapGrid.GetLength(1); j++)
                {
                    //Si position initiale du joueur = (0,0) = base
                    if (i == 0 && j == 0)
                    {
                        mapGrid[i, j] = 0; 
                        discovered[i, j] = true; 
                    }
                    else
                    {
                        mapGrid[i, j] = randomGenerator.Next(1, 7);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode qui affiche la carte du jeu
        /// </summary>
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


        /// <summary>
        /// Méthode qui réinitialise toutes les données du jeu
        /// </summary>
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

        /// <summary>
        /// Méthode qui commence un nouveau jeu
        /// </summary>
        public static void StartNewGame()
        {
            Map.ResetGame();
        }

        /// <summary>
        /// Méthode qui attribue une couleur spécifique à un terrain donné
        /// </summary>
        public static void SetTerrainColor(int terrain)
        {
            switch (terrain)
            {
                case 0: Console.BackgroundColor = ConsoleColor.White; break;
                case 1: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                case 2: Console.BackgroundColor = ConsoleColor.Green; break;
                case 3: Console.BackgroundColor = ConsoleColor.Yellow; break;
                case 4: Console.BackgroundColor = ConsoleColor.Blue; break;
                case 5: Console.BackgroundColor = ConsoleColor.Gray; break;
                case 6: Console.BackgroundColor = ConsoleColor.DarkGray; break;
                default: Console.BackgroundColor = ConsoleColor.Black; break;
            }
        }
        /// <summary>
        /// Méthode qui attribue un émoji à un terrain donné
        /// </summary>
        ///  /// <param name="terrain">Le terrain est généré aléatoirement</param>
        public static void SetTerrainEmoji(int terrain)
        {
            Console.OutputEncoding = Encoding.UTF8;
            switch (terrain)
            {
                case 0: Console.Write("🏠"); break;
                case 1: Console.Write("🌲"); break;
                case 2: Console.Write("🌿"); break;
                case 3: Console.Write("🏜️"); break;
                case 4: Console.Write("🌊"); break;
                case 5: Console.Write("🌫️"); break;
                case 6: Console.Write("⛰️"); break;
                default: Console.Write(""); break;
            }
        }
        /// <summary>
        /// Méthode qui détermine le terrain actuelle en fontion des nombres aléatoires générés plus haut dans la class
        /// </summary>
        public static string GetCurrentTerrain()
        {
            int terrain = mapGrid[playerPositionY, playerPositionX];
            switch (terrain)
            {
                case 0: return "Base";
                case 1: return "Forêt";
                case 2: return "Prairie";
                case 3: return "Désert";
                case 4: return "Rivière";
                case 5: return "Marais";
                case 6: return "Montagne";
                default: return "";
            }
        }
        /// <summary>
        /// Méthode qui colloecte les ressources sur chaque terrain, en fonction de leur probabilité de découverte
        /// </summary>
        public static void CollectMaterials()
        {
            string terrain = GetCurrentTerrain();
            switch (terrain)
            {
                case "Forêt": ProbabilityDiscoveryInForest(); break;
                case "Prairie": ProbabilityDiscoveryInPrairie(); break;
                case "Désert": ProbabilityDiscoveryInDesert(); break;
                case "Rivière": ProbabilityDiscoveryInRiver(); break;
                case "Marais": ProbabilityDiscoveryInSwamp(); break;
                case "Montagne": ProbabilityDiscoveryInMountain(); break;
                default: break;
            }
        }
        /// <summary>
        /// Probalité de collecte de ressources dans le désert
        /// </summary>
        public static void ProbabilityDiscoveryInDesert()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int roll = randomGenerator.Next(0, 100);

            if (roll < 10) 
            {
                Console.WriteLine("Vous avez collecté de l'eau 💧!");
                resourceAmounts[14]++; 
            }
            else if (roll < 90) 
            {
                Console.WriteLine("Vous avez collecté du sable ⏳");
                resourceAmounts[5]++; 
            }
            else 
            {
                Console.WriteLine("Vous n'avez rien trouvé...");
            }
        }

        /// <summary>
        /// Probalité de collecte de ressources dans la forèt
        /// </summary>
        public static void ProbabilityDiscoveryInForest()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int roll = randomGenerator.Next(0, 100);

            if (roll < 5)
            {
                int subChoice = randomGenerator.Next(0, 2);

                if (subChoice == 0)
                {
                    Console.WriteLine("Vous avez collecté de l'eau 💧");
                    resourceAmounts[14]++; 
                }
                else
                {
                    Console.WriteLine("Vous avez collecté des fruits 🍇");
                    resourceAmounts[13]++; 
                }
            }
            else if (roll < 15) 
            {
                Console.WriteLine("Vous avez collecté du gibier 🦌 ");
                resourceAmounts[15]++; 
            }
            else 
            {
                Console.WriteLine("Vous avez collecté du bois 🪵");
                resourceAmounts[1]++;
            }
        }

        /// <summary>
        /// Probalité de collecte de ressources dans le marais
        /// </summary>
        public static void ProbabilityDiscoveryInSwamp()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int roll = randomGenerator.Next(0, 100);

            if (roll < 5) 
            {
                Console.WriteLine("Vous avez collecté du poisson 🐟");
                resourceAmounts[15]++; 
            }
            else if (roll < 45) 
            {
                Console.WriteLine("Vous avez collecté de l'argile 🌰");
                resourceAmounts[3]++;
            }
            else 
            {
                Console.WriteLine("Vous avez collecté de l'eau 💧!");
                resourceAmounts[14]++; 
            }
        }

        /// <summary>
        /// Probalité de collecte de ressources dans la rivière
        /// </summary>
        public static void ProbabilityDiscoveryInRiver()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int roll = randomGenerator.Next(0, 100);

            if (roll < 20) 
            {
                Console.WriteLine("Vous avez collecté du poisson 🐟");
                resourceAmounts[15]++; 
            }
            else if (roll < 50) 
            {
                Console.WriteLine("Vous avez collecté de l'eau 💧");
                resourceAmounts[14]++;
            }
            else 
            {
                Console.WriteLine("Vous avez collecté du silex 🪨");
                resourceAmounts[2]++; 
            }
        }

        /// <summary>
        /// Probalité de collecte de ressources dans la prairie
        /// </summary>
        public static void ProbabilityDiscoveryInPrairie()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int roll = randomGenerator.Next(0, 100);

            if (roll < 30) 
            {
                Console.WriteLine("Vous avez collecté des fruits 🍇");
                resourceAmounts[13]++;
            }
            else 
            {
                Console.WriteLine("Vous avez collecté de l'herbe 🌱");
                resourceAmounts[4]++; 
            }
        }

        /// <summary>
        /// Probalité de collecte de ressources dans la montagne
        /// </summary>
        public static void ProbabilityDiscoveryInMountain()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int roll = randomGenerator.Next(0, 100);

            if (roll < 2) 
            {
                Console.WriteLine("Vous avez collecté de l'argile 🌰");
                resourceAmounts[3]++;
            }
            else if (roll < 7) 
            {
                Console.WriteLine("Vous avez collecté de l'eau 💧");
                resourceAmounts[14]++; 
            }
            else 
            {
                Console.WriteLine("Vous avez collecté du fer ⚙️ ");
                resourceAmounts[0]++; 
            }
        }

        /// <summary>
        /// Méthode qui montre le terrain en fonction du terrain actuel
        /// </summary>
        public static void ShowTerrainAtCurrentPosition()
        {
            discovered[playerPositionY, playerPositionX] = true;
            string terrain = GetCurrentTerrain();
            switch (terrain)
            {
                case "Base": ProcessDisplayBaseInput(); break;
                case "Forêt": ProcessDisplayForestInput(); break;
                case "Prairie": ProcessDisplayPrairieInput(); break;
                case "Désert": ProcessDisplayDesertInput(); break;
                case "Rivière": ProcessDisplayRiverInput(); break;
                case "Marais": ProcessDisplaySwampInput(); break;
                case "Montagne": ProcessDisplayMountainInput(); break;
            }
        }

        /// <summary>
        /// Méthode qui affiche le menu de base de chaque terrain
        /// </summary>
        ///  /// <param name="terrainName">Le nom du terrain</param>
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

        /// <summary>
        ///Méthode qui affiche la position du joueur lorsqu'il se trouve dans la forêt
        public static ConsoleKey DisplayForest()
        {
            Console.Clear();
            Display.DisplayForestPosition();
            return DisplayTerrainMenu("dans la forêt");
        }

        /// <summary>
        ///Méthode qui affiche la position du joueur lorsqu'il se trouve dans la prairie
        /// </summary>
        public static ConsoleKey DisplayPrairie()
        {
            Console.Clear();
            Display.DisplayPrairiePosition();
            return DisplayTerrainMenu("dans la prairie");
        }

        /// <summary>
        ///Méthode qui affiche la position du joueur lorsqu'il se trouve dasns le désert
        /// </summary>
        public static ConsoleKey DisplayDesert()
        {
            Console.Clear();
            Display.DisplayDesertPosition();
            return DisplayTerrainMenu("dans le désert");
        }

        /// <summary>
        ///Méthode qui affiche la position du joueur lorsqu'il se trouve près de la rivière
        /// </summary>
        public static ConsoleKey DisplayRiver()
        {
            Console.Clear();
            Display.DisplayRiverPosition();
            return DisplayTerrainMenu("près de la rivière");
        }

        /// <summary>
        ///Méthode qui affiche la position du joueur lorsqu'il se trouve dans le marais
        /// </summary>
        public static ConsoleKey DisplaySwamp()
        {
            Console.Clear();
            Display.DisplaySwampPosition();
            return DisplayTerrainMenu("dans le marais");
        }

        /// <summary>
        ///Méthode qui affiche la position du joueur lorsqu'il se trouve sur la montagne
        /// </summary>
        public static ConsoleKey DisplayMountain()
        {
            Console.Clear();
            Display.DisplayMountainPosition();
            return DisplayTerrainMenu("dans la montagne");
        }

        /// <summary>
        ///Méthode qui traite les actions effectués dans le menu du terrain de base
        /// </summary>
        public static bool ProcessDisplayBaseInput()
        {
            Console.ResetColor();
            bool stayAtBase = true;
            while (stayAtBase)
            {
                ConsoleKey input = Display.DisplayBase();
                Console.WriteLine();
                switch (input)
                {
                    case ConsoleKey.E: ProcessExplorationInput(); stayAtBase = false; break;
                    case ConsoleKey.A: Menu.ProcessInventoryInput(); break;
                    case ConsoleKey.F: Menu.ProcessDisplayManufacturingInput(); break;
                    case ConsoleKey.Escape: stayAtBase = false; Menu.ProcessDisplayMenuInput(); break;
                    case ConsoleKey.Q: Menu.ProcessDisplayLeaveMessageInput(); return false;
                    default:
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }
            return true;
        }
        /// <summary>
        ///Méthode qui affiche la limite de chaque coté de la carte
        /// </summary>
        ///  /// <param name="direction">Direction choisi (Nord, Sud, Est, Ouest)</param>
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

        /// <summary>
        ///Méthode qui traite les actions effectués dans le menu de déplacemnts
        /// </summary>
        public static void ProcessExplorationInput()
        {
            bool exploring = true;
            while (exploring)
            {
                ConsoleKey input = Display.DisplayDirection();
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
                        else { ShowBoundaryMessage("Nord"); }
                        break;

                    case ConsoleKey.O:
                    case ConsoleKey.LeftArrow:
                        if (playerPositionX > 0)
                        {
                            playerPositionX--;
                            exploring = ManageNumberOfTrip();
                            discovered[playerPositionY, playerPositionX] = true;
                        }
                        else { ShowBoundaryMessage("Ouest"); }
                        break;

                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        if (playerPositionY < mapGrid.GetLength(0) - 1)
                        {
                            playerPositionY++;
                            exploring = ManageNumberOfTrip();
                            discovered[playerPositionY, playerPositionX] = true;
                        }
                        else { ShowBoundaryMessage("Sud"); }
                        break;

                    case ConsoleKey.E:
                    case ConsoleKey.RightArrow:
                        if (playerPositionX < mapGrid.GetLength(1) - 1)
                        {
                            playerPositionX++;
                            exploring = ManageNumberOfTrip();
                            discovered[playerPositionY, playerPositionX] = true;
                        }
                        else { ShowBoundaryMessage("Est"); }
                        break;

                    case ConsoleKey.Enter: ShowTerrainAtCurrentPosition(); exploring = false; break;
                    case ConsoleKey.Escape: exploring = false; Console.Clear(); Menu.ProcessDisplayMenuInput(); break;
                    case ConsoleKey.Q: exploring = false; Console.Clear(); Menu.ProcessDisplayLeaveMessageInput(); break;
                    default: Display.AnimateText("Direction invalide. Veuillez réessayer."); Thread.Sleep(1500); break;
                }
            }
        }

        /// <summary>
        ///Méthode qui traite les actions effectués dans le menu de chaque terrain. Cette méthode prends en paramètre une méthode de type ConsoleKey. La référence est StackOverflow.
        /// </summary>
        /// /// <param name="displayFunction">Ce paramètre représente une méthode qui affiche le terrain (DisplayForest par exemple)</param>
        public static bool ProcessTerrainInput(Func<ConsoleKey> displayFunction)
        {
            bool stayInTerrain = true;
            while (stayInTerrain)
            {
                ConsoleKey input = displayFunction();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E: ProcessExplorationInput(); stayInTerrain = false; break;
                    case ConsoleKey.A: Menu.ProcessInventoryInput(); break;
                    case ConsoleKey.C: CollectMaterials(); Console.ReadKey(); break;
                    case ConsoleKey.M: Crafting.EatFruits(); Display.WaitForKeyPress(); break;
                    case ConsoleKey.B: Crafting.DrinkWater(); Display.WaitForKeyPress(); break;
                    case ConsoleKey.Escape: stayInTerrain = false; Menu.ProcessDisplayMenuInput(); break;
                    case ConsoleKey.Q: Menu.ProcessDisplayLeaveMessageInput(); return false;
                    default:
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }
            return true;
        }

        /// <summary>
        ///Méthode qui traite les actions effectués dans la forêt
        /// </summary>
        public static bool ProcessDisplayForestInput()
        {
            return ProcessTerrainInput(DisplayForest);
        }
        /// <summary>
        ///Méthode qui traite les actions effectués dans la prairie
        /// </summary>
        public static bool ProcessDisplayPrairieInput()
        {
            return ProcessTerrainInput(DisplayPrairie);
        }
        /// <summary>
        ///Méthode qui traite les actions effectués dans le désert
        /// </summary>
        public static bool ProcessDisplayDesertInput()
        {
            return ProcessTerrainInput(DisplayDesert);
        }
        /// <summary>
        ///Méthode qui traite les actions effectués dans la rivière
        /// </summary>
        public static bool ProcessDisplayRiverInput()
        {
            return ProcessTerrainInput(DisplayRiver);
        }
        /// <summary>
        ///Méthode qui traite les actions effectués dans le marais
        /// </summary>
        public static bool ProcessDisplaySwampInput()
        {
            return ProcessTerrainInput(DisplaySwamp);
        }
        /// <summary>
        ///Méthode qui traite les actions effectués dans la montagne
        /// </summary>
        public static bool ProcessDisplayMountainInput()
        {
            return ProcessTerrainInput(DisplayMountain);
        }
    }
}