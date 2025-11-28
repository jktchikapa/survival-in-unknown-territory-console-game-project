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

        public static void DataSerialisation()
        {
            try
            {
                File.Delete(FileName);
                File.AppendAllText(FileName, JsonSerializer.Serialize(Map.playerPositionX) + "\n");
                File.AppendAllText(FileName, JsonSerializer.Serialize(Map.playerPositionY) + "\n");

                //Créer une nouvelle liste qui contiendra les valeurs du tableau mapGrid
                List<List<int>> mapGridList = new List<List<int>>();
                // le i représente le numéro de la ligne du tableau
                for (int i = 0; i < 10; i++)
                {
                    //Créer une nouvelle listes pour chaque ligne du tableau,on va stocker les lignes
                    List<int> row = new List<int>();
                    //le j représente le numéro de la colonne, on va parcourir toute les colonnes de la ligne i et on va stocker chaque valeur dans le row
                    for (int j = 0; j < 10; j++)
                    {
                        row.Add(Map.mapGrid[i, j]);
                    }
                    // quand la ligne est rempli on ajoute la ligne dans la liste
                    mapGridList.Add(row);
                }
                File.AppendAllText(FileName, JsonSerializer.Serialize(mapGridList) + "\n");
                //même choses que pour le préceédent, juste que c'est une liste de bool
                List<List<bool>> discoveredList = new List<List<bool>>();
                for (int i = 0; i < 10; i++)
                {
                    List<bool> row = new List<bool>();
                    for (int j = 0; j < 10; j++)
                    {
                        row.Add(Map.discovered[i, j]);
                    }
                    discoveredList.Add(row);
                }
                File.AppendAllText(FileName, JsonSerializer.Serialize(discoveredList) + "\n");

                File.AppendAllText(FileName, JsonSerializer.Serialize(Map.resourceAmounts) + "\n");
                File.AppendAllText(FileName, JsonSerializer.Serialize(Map.numberOfTripsRemaining) + "\n");

                Console.Clear();
                Display.AnimateText("Partie sauvegardée avec succès !", ConsoleColor.Green);
                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Erreur lors de la sauvegarde : {ex.ToString()}");
                Console.ResetColor();
                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();
            }
        }

        public static void DataDeserialisation()
        {
            try
            {
                if (!File.Exists(FileName))
                {
                    Console.Clear();
                    Display.AnimateText("Aucune sauvegarde trouvée.", ConsoleColor.Yellow);
                    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                    Console.ReadKey();
                    return;
                }

                string[] loaded = File.ReadAllLines(FileName);
                Map.playerPositionX = JsonSerializer.Deserialize<int>(loaded[0]);
                Map.playerPositionY = JsonSerializer.Deserialize<int>(loaded[1]);

                List<List<int>> mapGridList = JsonSerializer.Deserialize<List<List<int>>>(loaded[2]);
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Map.mapGrid[i, j] = mapGridList[i][j];
                    }
                }

                List<List<bool>> discoveredList = JsonSerializer.Deserialize<List<List<bool>>>(loaded[3]);
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Map.discovered[i, j] = discoveredList[i][j];
                    }
                }

                Map.resourceAmounts = JsonSerializer.Deserialize<int[]>(loaded[4]);
                Map.numberOfTripsRemaining = JsonSerializer.Deserialize<int>(loaded[5]);

                Console.Clear();
                Display.AnimateText("Partie chargée avec succès !", ConsoleColor.Green);
                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();

                Map.ShowTerrainAtCurrentPosition();
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