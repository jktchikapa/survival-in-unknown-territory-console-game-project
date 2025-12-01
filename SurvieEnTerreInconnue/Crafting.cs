using System;
using System.Reflection;
using System.Xml.Linq;

namespace SurvieEnTerreInconnue
{
    internal class Crafting
    {
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
        public static void BuildHouse()
        {
            int missingPlanks = 4 - Map.resourceAmounts[9];
            int missingBricks = 4 - Map.resourceAmounts[10];
            int missingInsulators = 4 - Map.resourceAmounts[11];
            int missingGlass = 2 - Map.resourceAmounts[8];

            if (missingPlanks <= 0 && missingBricks <= 0 && missingInsulators <= 0 && missingGlass <= 0)
            {
                Menu.DisplayEndMessage();
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

        public static void BuildAxe()
        {
            int missingWood = 1 - Map.resourceAmounts[1];
            int missingIron = 1 - Map.resourceAmounts[0];

            if (missingWood <= 0 && missingIron <= 0)
            {   
                Console.WriteLine("Vous avez fabriqué une hache !");
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

        public static void BuildGlass()
        {
            int missingSand = 1 - Map.resourceAmounts[5];
            int missingFire = 1 - Map.resourceAmounts[6];

            if (missingSand <= 0 && missingFire <= 0)
            {
                Console.WriteLine("Vous avez fabriqué une vitre !");
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
       
        public static void BuildPlank()
        {
            int missingWood = 1 - Map.resourceAmounts[1];
            int missingAxe = 1 - Map.resourceAmounts[7];

            if (missingWood <= 0 && missingAxe <= 0)
            {
                Console.WriteLine("Vous avez fabriqué une planche !");
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

        public static void BuildBrick()
        {
            int missingClay = 1 - Map.resourceAmounts[3];
            int missingFire = 1 - Map.resourceAmounts[6];

            if (missingClay <= 0 && missingFire <= 0)
            {
                Console.WriteLine("Vous avez fabriqué une brique !");
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
       
        public static void BuildInsulator()
        {
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

        public static void BuildFire()
        {
            int missingWood = 1 - Map.resourceAmounts[1];
            int missingFlint = 1 - Map.resourceAmounts[2];

            if (missingWood <= 0 && missingFlint <= 0)
            {
                Console.WriteLine("Vous avez fabriqué du feu !");
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
       
        public static void CookFish()
        {
            int missingFish = 1 - Map.resourceAmounts[16];

            if(missingFish <= 0)
            {
                Console.WriteLine("\nVous avez cuisiner un poisson. Bonne appétit. Profitez bien des 30% d'énergie que ce repas vous offre !");
                Map.resourceAmounts[16]--; 
                Map.resourceAmounts[6]--; 
                Map.playerEnergy += 30;
            }
            else
            {
                Console.WriteLine($"\nVous ne pouvez pas cuisiner de poisson, il vous manque au moins {missingFish} poisson pour pouvoir le cuisiner");
                HintWhereToFind(8);
            }
        }

        public static void CookMeat()
        {
            int missingMeal = 1 - Map.resourceAmounts[15];

            if(missingMeal <= 0)
            {
                Console.WriteLine("\nVous avez cuisiné du gibier. Bonne appétit. Profitez bien des 50% d'énergie que ce repas vous offre ! ");
                Map.resourceAmounts[15]--; 
                Map.resourceAmounts[6]--;  
                Map.playerEnergy += 50;
            }

            else
            {
                Console.WriteLine($"\nVous ne pouvez pas cuisiner de gibier, il vous faut au {missingMeal} gibier pour pouvoir le cuisiner");
                HintWhereToFind(7);
            }
        }
        /* 5 = fruits; 6 = eau; 7 = gibier; 8 = poisson*/
        public static void DrinkWater()
        {
            int missingWater = 1 - Map.resourceAmounts[14];

            if(missingWater <= 0)
            {
                Console.WriteLine("Vous avez bu de l'eau. Vous avez +5%% d'énergie");
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
        public static void EatFruits()
        {
            int missingFruits = 1 - Map.resourceAmounts[13];

            if(missingFruits <= 0)
            {
                Console.WriteLine("Vous mangé un fruits, vous avez +10% d'energie ");
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

        public static void MaxPlayerEnergy()
        {
            if (Map.playerEnergy > 100)
            {
                Map.playerEnergy = 100;
            }
        }

    }
}
