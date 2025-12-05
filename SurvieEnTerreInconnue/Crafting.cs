using System;
using System.Reflection;
using System.Xml.Linq;

namespace SurvieEnTerreInconnue
{
    internal class Crafting
    {
        /// <summary>
        /// Méthode qui affiche le message d'aide pour trouver les ressources manquantes
        /// </summary>
        /// <param name="index">Indice de la ressources manquantes</param>
        public static void HintWhereToFind(int index)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            switch (index)
            {
                case 0:
                    Console.WriteLine("\nIndice : Vous trouverez du fer dans la montagne.\n");
                    break;
                case 1:
                    Console.WriteLine("\nIndice : Vous trouverez du bois dans la forêt.\n");
                    break;
                case 2:
                    Console.WriteLine("\nIndice : Vous trouverez du silex dans la rivière.\n");
                    break;
                case 3:
                    Console.WriteLine("\nIndice : Vous trouverez de l'argile dans le marais.\n");
                    break;
                case 4:
                    Console.WriteLine("\nIndice : Vous trouverez de l'herbe dans la prairie.\n"); 
                    break;
                case 5:
                    Console.WriteLine("\nIndice : Vous trouvez des fruits dans la forêt \n");
                    break;
                case 6:
                    Console.WriteLine("\nIndice : Vous trouverez de l'eau dans le marais et la rivière\n");
                    break;
                case 7: 
                    Console.WriteLine("\nIndice : Vous trouverez du gibier dans la forêt\n");
                    break;
                case 8: 
                    Console.WriteLine("\nIndice : Vous trouverez du poisson dans la rivière et le marais \n");
                    break;
                case 9:
                    Console.WriteLine("\nIndice : Vous trouverez du sable dans le désert \n");
                    break;
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Méthode qui permet de fabriquer une maison
        /// </summary>
        public static void BuildHouse()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingPlanks = 4 - Map.resourceAmounts[9];
            int missingBricks = 4 - Map.resourceAmounts[10];
            int missingInsulators = 4 - Map.resourceAmounts[11];
            int missingGlass = 2 - Map.resourceAmounts[8];

            if (missingPlanks <= 0 && missingBricks <= 0 && missingInsulators <= 0 && missingGlass <= 0)
            {
                Display.DisplayEndMessage();
                Map.resourceAmounts[9] -= 4;
                Map.resourceAmounts[10] -= 4;
                Map.resourceAmounts[11] -= 4;
                Map.resourceAmounts[8] -= 2;
                Map.resourceAmounts[12]++;
            }
            else
            {
                Console.WriteLine("Impossible de construire la maison, il manque :");

                if (missingPlanks > 0)
                {
                    Console.WriteLine($"- {missingPlanks} planche(s)");
                } 
                if (missingBricks > 0) 
                {
                    Console.WriteLine($"- {missingBricks} brique(s)");
                }
                if (missingInsulators > 0) 
                { 
                    Console.WriteLine($"- {missingInsulators} isolant(s)");
                }
                if (missingGlass > 0)
                {
                    Console.WriteLine($"- {missingGlass} vitre(s)");
                }
            }
        }

        /// <summary>
        /// Méthode qui permet de fabriquer une hache
        /// </summary>
        public static void BuildAxe()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingWood = 1 - Map.resourceAmounts[1];
            int missingIron = 1 - Map.resourceAmounts[0];

            if (missingWood <= 0 && missingIron <= 0)
            {   
                Console.WriteLine("Vous avez fabriqué une hache 🪓 !");
                Map.resourceAmounts[1]--;
                Map.resourceAmounts[0]--;
                Map.resourceAmounts[7]++;
            }
            else
            {
                Console.WriteLine("Impossible de fabriquer une hache, il manque :");
                if (missingWood > 0)
                {
                    Console.WriteLine("- 1 bois");
                    HintWhereToFind(1);
                }
                if (missingIron > 0)
                {
                    Console.WriteLine("- 1 fer");
                    HintWhereToFind(0);
                }
            }
        }

        /// <summary>
        /// Méthode qui permet de fabriquer une vitre
        public static void BuildGlass()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingSand = 1 - Map.resourceAmounts[5];
            int missingFire = 1 - Map.resourceAmounts[6];

            if (missingSand <= 0 && missingFire <= 0)
            {
                Console.WriteLine("Vous avez fabriqué une vitre 🪟!");
                Map.resourceAmounts[5]--;
                Map.resourceAmounts[6]--;
                Map.resourceAmounts[8]++;
            }
            else
            {
                Console.WriteLine("Impossible de fabriquer une vitre, il manque :");

                if (missingSand > 0)
                {
                    Console.WriteLine("- 1 sable");
                    HintWhereToFind(9);
                }
                if (missingFire > 0)
                {
                    Console.WriteLine("- 1 feu");
                    HintWhereToFind(6);
                }
            }
        }

        /// <summary>
        /// Méthode qui permet de fabriquer une planche
        /// </summary>
        public static void BuildPlank()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingWood = 1 - Map.resourceAmounts[1];
            int missingAxe = 1 - Map.resourceAmounts[7];

            if (missingWood <= 0 && missingAxe <= 0)
            {
                Console.WriteLine("Vous avez fabriqué une planche 🪵 !");
                Map.resourceAmounts[1]--;
                Map.resourceAmounts[7]--;
                Map.resourceAmounts[9]++;
            }
            else
            {
                Console.WriteLine("Impossible de fabriquer une planche, il manque :");

                if (missingWood > 0)
                {
                    Console.WriteLine("- 1 bois");
                    HintWhereToFind(1);
                }
                if (missingAxe > 0)
                {
                    Console.WriteLine("- 1 hache");
                } 
            }
        }

        /// <summary>
        /// Méthode qui permet de fabriquer une brique
        /// </summary>
        public static void BuildBrick()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingClay = 1 - Map.resourceAmounts[3];
            int missingFire = 1 - Map.resourceAmounts[6];

            if (missingClay <= 0 && missingFire <= 0)
            {
                Console.WriteLine("Vous avez fabriqué une brique 🧱!");
                Map.resourceAmounts[3]--;
                Map.resourceAmounts[6]--;
                Map.resourceAmounts[10]++;
            }
            else
            {
                Console.WriteLine("Impossible de fabriquer une brique, il manque :");
                if (missingClay > 0) 
                {
                    Console.WriteLine("- 1 argile");
                    HintWhereToFind(3);
                }
                if (missingFire > 0) 
                {
                    Console.WriteLine("- 1 feu");
                    HintWhereToFind(6);
                }
            }
        }

        /// <summary>
        /// Méthode qui permet de faire des isolants
        /// </summary>
        public static void BuildInsulator()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingGrass = 3 - Map.resourceAmounts[4];

            if (missingGrass <= 0)
            {
                Console.WriteLine("Vous avez fabriqué un isolant !");
                Map.resourceAmounts[4] -= 3;
                Map.resourceAmounts[11]++;
            }
            else
            {
                Console.WriteLine("Impossible de fabriquer un isolant, il manque :");
                Console.WriteLine($"- {missingGrass} herbe(s)");
                HintWhereToFind(4);
            }
        }

        /// <summary>
        /// Méthode qui permet de faire du feu
        /// </summary>
        public static void BuildFire()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingWood = 1 - Map.resourceAmounts[1];
            int missingFlint = 1 - Map.resourceAmounts[2];

            if (missingWood <= 0 && missingFlint <= 0)
            {
                Console.WriteLine("Vous avez fabriqué du feu 🔥!");
                Map.resourceAmounts[1]--;
                Map.resourceAmounts[2]--;
                Map.resourceAmounts[6]++;
            }
            else
            {
                Console.WriteLine("Impossible de fabriquer du feu, il manque :");

                if (missingWood > 0)
                {
                    Console.WriteLine("- 1 bois");
                    HintWhereToFind(1);

                }
                if (missingFlint > 0) 
                {
                    Console.WriteLine("- 1 silex");
                    HintWhereToFind(2);
                }
            }
        }

        /// <summary>
        /// Méthode qui permet de préparer du poisson
        /// </summary>
        public static void CookFish()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingFish = 1 - Map.resourceAmounts[16];

            if(missingFish <= 0)
            {
                Console.WriteLine("\nVous avez cuisiner un poisson 🐠. Bonne appétit. Profitez bien des 30% d'énergie ⚡ que ce repas vous offre !");
                Map.resourceAmounts[16]--; 
                Map.resourceAmounts[6]--; 
                Map.playerEnergy += 30;
                MaxPlayerEnergy();
            }
            else
            {
                Console.WriteLine($"\nVous ne pouvez pas cuisiner de poisson, il vous manque au moins {missingFish} poisson pour pouvoir le cuisiner");
                HintWhereToFind(8);
            }
        }

        /// <summary>
        /// Méthode qui permet de préaprer du gibier
        /// </summary>
        public static void CookMeat()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingMeal = 1 - Map.resourceAmounts[15];

            if(missingMeal <= 0)
            {
                Console.WriteLine("\nVous avez cuisiné du gibier 🍖. Bonne appétit. Profitez bien des 50% d'énergie⚡ que ce repas vous offre ! ");
                Map.resourceAmounts[15]--; 
                Map.resourceAmounts[6]--;  
                Map.playerEnergy += 50;
                MaxPlayerEnergy();
            }
            else
            {
                Console.WriteLine($"\nVous ne pouvez pas cuisiner de gibier, il vous faut au {missingMeal} gibier pour pouvoir le cuisiner");
                HintWhereToFind(7);
            }
        }


        /// <summary>
        /// Méthode qui permet de boire de l'eau
        /// </summary>
        public static void DrinkWater()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingWater = 1 - Map.resourceAmounts[14];

            if(missingWater <= 0)
            {
                Console.WriteLine("Vous avez bu de l'eau 💧. Vous avez +5%% d'énergie ⚡");
                Map.resourceAmounts[14]--;
                Map.playerEnergy += 5;
                MaxPlayerEnergy();
            }
            else
            {
                Console.WriteLine("Impossible de boire de l'eau, il manque de l'eau dans votre inventaire");
                HintWhereToFind(6);
            }
        }

        /// <summary>
        /// Méthode qui permet de manger des fruits
        /// </summary>
        public static void EatFruits()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int missingFruits = 1 - Map.resourceAmounts[13];

            if(missingFruits <= 0)
            {
                Console.WriteLine("Vous mangé un fruits 🍇, vous avez +10% d'energie ⚡");
                Map.resourceAmounts[13]--;
                Map.playerEnergy += 10;
                MaxPlayerEnergy();

            }
            else
            {
                Console.WriteLine("Impossible de manger un fruit, il manque des fruits dans votre inventaire");
                HintWhereToFind(5);
            }
        }

        /// <summary>
        /// Méthode qui initialise le max d'énergie du joueur à 100%
        /// </summary>
        public static void MaxPlayerEnergy()
        {
            if (Map.playerEnergy > 100)
            {
                Map.playerEnergy = 100;
            }
        }
    }
}
