using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace SurvieEnTerreInconnue
{
    internal class Game
    {
        public const string FileName = "data.txt";

        /// <summary>
        ///Méthode qui sérialise les données du jeu
        /// </summary>
        public static void DataSerialisation()
        {
            try
            {
                File.Delete(FileName);
                File.AppendAllText(FileName, JsonSerializer.Serialize(Map.playerPositionX) + "\n");
                File.AppendAllText(FileName, JsonSerializer.Serialize(Map.playerPositionY) + "\n");

                // Créer la liste  vide
                List<List<int>> mapGridList = new List<List<int>>();
                for (int i = 0; i < Map.mapGrid.GetLength(0); i++) // Boucle sur les lignes (i)
                {
                    List<int> row = new List<int>(); // Nouvelle ligne vide
                    for (int j = 0; j < Map.mapGrid.GetLength(1); j++) // Boucle sur les colonnes (j)
                    {
                        row.Add(Map.mapGrid[i, j]); // Ajouter chaque case
                    }
                    mapGridList.Add(row); // Ajouter la ligne à la liste
                }
                File.AppendAllText(FileName, JsonSerializer.Serialize(mapGridList) + "\n");
                List<List<bool>> discoveredList = new List<List<bool>>();
                for (int i = 0; i < Map.discovered.GetLength(0); i++)
                {
                    List<bool> row = new List<bool>();
                    for (int j = 0; j < Map.discovered.GetLength(1); j++)
                    {
                        row.Add(Map.discovered[i, j]);
                    }
                    discoveredList.Add(row);
                }
                File.AppendAllText(FileName, JsonSerializer.Serialize(discoveredList) + "\n");
                File.AppendAllText(FileName, JsonSerializer.Serialize(Map.resourceAmounts) + "\n");
                File.AppendAllText(FileName, JsonSerializer.Serialize(Map.numberOfTripsRemaining) + "\n");
                File.AppendAllText(FileName, JsonSerializer.Serialize(Map.playerEnergy) + "\n");
                Console.Clear();
                Console.WriteLine("Sauvegarde de la partie effectué avec succès");
                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Erreur lors de la sauvegarde : {ex.ToString()}");
                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();
            }
        }

        /// <summary>
        ///Méthode qui désérialise les données du jeu
        /// </summary>
        public static void DataDeserialisation()
        {
            try
            {
                if (!File.Exists(FileName)) 
                {
                    Console.Clear();
                    Display.AnimateText("Aucune sauvegarde trouvée.");
                    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                    Console.ReadKey();
                    return;
                }
                string[] loaded = File.ReadAllLines(FileName);
                Map.playerPositionX = JsonSerializer.Deserialize<int>(loaded[0]);
                Map.playerPositionY = JsonSerializer.Deserialize<int>(loaded[1]);

                List<List<int>> mapGridList = JsonSerializer.Deserialize<List<List<int>>>(loaded[2]);
                for (int i = 0; i < Map.mapGrid.GetLength(0); i++)
                {
                    for (int j = 0; j < Map.mapGrid.GetLength(1); j++)
                    {
                        Map.mapGrid[i, j] = mapGridList[i][j];
                    }
                }
                List<List<bool>> discoveredList = JsonSerializer.Deserialize<List<List<bool>>>(loaded[3]);
                for (int i = 0; i < Map.discovered.GetLength(0); i++)
                {
                    for (int j = 0; j < Map.discovered.GetLength(1); j++)
                    {
                        Map.discovered[i, j] = discoveredList[i][j];
                    }
                }
                Map.resourceAmounts = JsonSerializer.Deserialize<int[]>(loaded[4]);
                Map.numberOfTripsRemaining = JsonSerializer.Deserialize<int>(loaded[5]);
                Map.playerEnergy = JsonSerializer.Deserialize<int>(loaded[6]);
                Console.Clear();
                Display.AnimateText("Partie chargée avec succès !");
                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();
                if(Map.playerPositionX == 0 && Map.playerPositionY == 0)
                {
                    Map.GenerateMap();
                    Map.ShowTerrainAtCurrentPosition();
                }
                else
                {
                    Map.ShowTerrainAtCurrentPosition();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erreur lors du chargement : {ex.ToString()}");
                Console.ResetColor();
                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();
            }
        }
    }
}