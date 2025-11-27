using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SurvieEnTerreInconnue
{
    internal class Game
    {
        public const string FileName = "data.txt";
        public static void DataSerialisation()
        {
            File.Delete(FileName);
            File.AppendAllText(FileName, JsonSerializer.Serialize(Map.playerPosition) + "\n");
            File.AppendAllText(FileName, JsonSerializer.Serialize(Map.resourceAmounts) + "\n");
            
        }
        public static void DataDeserialisation()
        {
            string fileData = File.ReadAllText(FileName);

            List<int> playerPositon = JsonSerializer.Deserialize<List<int>>(fileData[0]);
            int[] resourceAmounts = JsonSerializer.Deserialize<int[]>(fileData[1]);
        }
    }
}
