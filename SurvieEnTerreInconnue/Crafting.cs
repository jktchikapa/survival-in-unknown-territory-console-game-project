using System;
using System.Xml.Linq;

namespace SurvieEnTerreInconnue
{
    internal class Crafting
    {
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
                    Console.WriteLine("\nVous trouvez des fruits dans \n");
                    break;
                case 6:
                    Console.WriteLine("\nVous trouverez de l'eau dans \n");
                    break;
                case 7:
                    Console.WriteLine("\nVous trouverez du gibier dans \n");
                    break;
                case 8:
                    Console.WriteLine("\nVous trouverez du poisson dans \n");
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
                Menu.ProcessDisplayEndMessageInput();
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
                    HintWhereToFind(5);
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
    }
}
