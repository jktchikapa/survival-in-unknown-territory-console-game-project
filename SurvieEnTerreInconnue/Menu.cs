using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvieEnTerreInconnue
{
    internal class Menu
    {
        static void DisplayFrame(string texte)
        {
            int length = texte.Length;
            Console.WriteLine($"╔{new string('═', length)}╗");
            Console.WriteLine($"║{texte}║");
            Console.WriteLine($"╚{new string('═', length)}╝");
        }

        public static ConsoleKey DisplayMenu()
        {
            Console.Clear();
            DisplayFrame("Menu principal du jeu Survie En Terre Inconnu");
            Console.WriteLine();
            Console.WriteLine("Veuillez sélectionner une action :");
            Console.WriteLine("[J]ouer");
            Console.WriteLine("[D]émarer une nouvelle partie");
            Console.WriteLine("[S]auvegarder une partie");
            Console.WriteLine("[C]rédits");
            Console.WriteLine("[Q]uitter");
            Console.WriteLine();
            Console.Write("Votre choix : ");
            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static void ProcessDisplayMenuInput()
        {
            bool continueGame = true;

            while (continueGame)
            {
                ConsoleKey input = DisplayMenu();

                switch (input)
                {
                    case ConsoleKey.J:
                        Console.Clear();
                        Display.AnimateText("Chargement de la partie...");
                        Thread.Sleep(1000);
                        break;

                    case ConsoleKey.D:
                        Console.Clear();
                        Display.DisplayWelcomeMessage();
                        break;

                    case ConsoleKey.S:
                        Console.Clear();
                        Display.AnimateText("Partie sauvegardée avec succès !");
                        Thread.Sleep(2000);
                        break;

                    case ConsoleKey.C:
                        Console.Clear();
                        Console.WriteLine("\nAppuyez sur une touche pour retourner au menu...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Q:
                        continueGame = ProcessDisplayLeaveMessageInput();
                        break;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }

        public static ConsoleKey DisplayLeaveMessage()
        {
            Console.Clear();
            Display.AnimateText("Êtes vous sûr de vouloir quitter la partie ?");
            Console.WriteLine();
            Console.WriteLine("[O]ui, je souhaite quitter la partie");
            Console.WriteLine("[N]on, je ne souhaite plus quitter la partie");
            Console.WriteLine("[S]auvegarder ma progression et quitter");
            Console.WriteLine();
            Console.Write("Votre choix : ");
            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayLeaveMessageInput()
        {
            ConsoleKey input = DisplayLeaveMessage();

            switch (input)
            {
                case ConsoleKey.O:
                    Console.Clear();
                    DisplayGoodByeMessage();
                    Thread.Sleep(3000);
                    return false;

                case ConsoleKey.N:
                    return true;

                case ConsoleKey.S:
                    Console.Clear();
                    Display.AnimateText("Sauvegarde en cours...");
                    Thread.Sleep(1000);
                    Display.AnimateText("\nPartie sauvegardée avec succès !");
                    Thread.Sleep(1500);
                    Console.Clear();
                    DisplayGoodByeMessage();
                    Thread.Sleep(3000);
                    return false;

                default:
                    Display.AnimateText("Choix invalide. Retour au menu...");
                    Thread.Sleep(1500);
                    return true;
            }
        }

        public static void DisplayGoodByeMessage()
        {
            Display.AnimateText("Vous avez ainsi fait votre choix, nous espérons que le jeu vous aura plu.");
            Console.WriteLine();
            Display.AnimateText("Nous espérons vous revoir bientôt !");
            Console.WriteLine();
        }

        public static void DisplayGameHistory()
        {
            Display.AnimateText("\t\t\t\tMise en contexte de l'histoire ...\t");
            Display.AnimateText("\n\tVous êtes le seul survivant à un crash d'avion");
            Console.WriteLine();
            Thread.Sleep(1000);
            Display.AnimateText("\tVous êtes sur une île abandonnée, aucun signe de vie aux alentours");
            Console.WriteLine();
            Thread.Sleep(1000);
            Display.AnimateText("\tL'hiver approche ...");
            Console.WriteLine();
            Thread.Sleep(1000);
            Display.AnimateText("\tConstruisez-vous un abri au plus vite si vous souhaitez survivre ...");
            Console.WriteLine();
        }

        public static void DisplayStartMessage()
        {
            Display.AnimateText("Le jeu commençera dans :");
            Thread.Sleep(2000);
            Display.CountDown();
            Console.Clear();
        }
        public static ConsoleKey DisplayEndMessage()
        {
            Console.Clear();
            Display.AnimateText("Les premiers flocons tombent doucement sur le toit de votre abri..");
            Thread.Sleep(1500);
            Console.WriteLine();

            Display.AnimateText("Vous avez réussi. Contre toute attente, vous avez survécu.");
            Thread.Sleep(2000);
            Console.WriteLine();

            Display.AnimateText("\"Votre maison vous protégera du froid glacial de l'hiver qui approche+");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine();

            Display.AnimateText("Mais au fond de vous, une question persiste...");
            Thread.Sleep(1000);
            Console.WriteLine();

            Display.AnimateText("Allez-vous rester ici pour toujours ?");
            Thread.Sleep(1000);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Display.AnimateText("Êtes-vous prêt à continuer votre aventure ? ");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("[O]ui, je veux m'échapper de cette île !");
            Console.WriteLine("[N]on, je préfere rester en sécurité ici");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static void ProcessDisplayEndMessageInput()
        {
            ConsoleKey input = DisplayEndMessage();
            Console.WriteLine();
            Console.WriteLine();

            switch (input)
            {
                case ConsoleKey.O:
                    Display.AnimateText("Votre aventure débute dès maintenant.");
                    Thread.Sleep(2000);
                    break;

                case ConsoleKey.N:
                    Display.AnimateText("Peut-être partirez-vous un jour...");
                    Thread.Sleep(2000);
                    break;

                default:
                    Display.AnimateText("Merci d'avoir joué !");
                    Thread.Sleep(2000);
                    break;
            }
        }
        public static ConsoleKey DisplayManufacturingMenu()
        {
            Console.Clear();
            Display.DisplayManufacturingItems();
            Console.WriteLine();

            Console.WriteLine("\t\t***********************************************************");
            Console.WriteLine("[F]eu : Cette action nécessite du Bois et du Silex");
            Console.WriteLine("[H]ache : Cette action nécessite du Bois et Du Fer");
            Console.WriteLine("[V]itre : Cette action nécessite du Sable et du Feu");
            Console.WriteLine("[P]lanche : Cette action nécessite du Bois ainsi qu'une Hache");
            Console.WriteLine("[B]rique : Cette action nécessite du Feu et de l'Argile");
            Console.WriteLine("[I]solant : Cette action nécessite 3x de l'herbe");
            Console.WriteLine("[M]aison : Cette action nécessite 4x des Planches, 4x des Isolants, 4x des Briques ainsi que 2x des Vitres");
            Console.WriteLine("[N]ourriture : Cette action nécéssite du Feu et du Bois ");
            Console.WriteLine("[C]onsulter Inventaire : Vous pouvez consulter votre inventaire");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine("\t\t***********************************************************");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayManufacturingInput()
        {
            bool continueManufacturing = true;

            while (continueManufacturing)
            {
                ConsoleKey input = DisplayManufacturingMenu();
                Console.WriteLine(); 

                switch (input)
                {
                    case ConsoleKey.F:
                        Console.Clear();
                        Crafting.BuildFire();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.H:
                        Console.Clear();
                        Crafting.BuildAxe();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.V:
                        Console.Clear();
                        Crafting.BuildGlass();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.P:
                        Console.Clear();
                        Crafting.BuildPlank();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.Clear();
                        Crafting.BuildBrick();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.I:
                        Console.Clear();
                        Crafting.BuildInsulator();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.M:
                        Console.Clear();
                        Crafting.BuildHouse();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.C:
                        ProcessInventoryInput();
                        break;

                    case ConsoleKey.R:
                        ProcessDisplayMenuInput();
                        return true; 

                    case ConsoleKey.Q:
                        return false; 

                    default:
                        Console.Clear();
                        Display.AnimateText("Action annulée. Retour au menu de fabrication...");
                        Thread.Sleep(1500);
                        break;
                }
            }

            return true;
        }

        public static ConsoleKey DisplayInventoryPrincipalMenu()
        {
            Console.Clear();
            Display.DisplayInventoryItems();
            Console.WriteLine();
            Display.AnimateText("Bienvenue dans l'inventaire du jeu");
            Console.WriteLine();
            Thread.Sleep(1000);
            Display.AnimateText("\nDans cette section, vous pouvez consulter toutes les ressources et matériaux à votre disposition");
            Thread.Sleep(1000);
            Console.WriteLine();
            Display.AnimateText("\nVeuillez sélectionner une option :");
            Console.WriteLine();
            Console.WriteLine("[R]essources : Consultez les ressources que vous possédez");
            Console.WriteLine("[M]atériaux : Consulter les matériaux que vous avez fabriqué");
            Console.WriteLine("[Q]uitter l'inventaire");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static void ProcessInventoryInput()
        {
            bool continueInventory = true;

            while (continueInventory)
            {
                ConsoleKey input = DisplayInventoryPrincipalMenu();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.R:
                        DisplayInventoryMenu1();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.M:
                        DisplayInventoryMenu2();
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Q:
                        continueInventory = false;
                        break;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }
        }

        public static void DisplayInventoryMenu1()
        {
            Console.Clear();
            Display.DisplayInventoryItem1();
            Console.WriteLine();

            Console.WriteLine("\t\t***********************************");
            Console.WriteLine($"Nombres de Fer en stock: ");
            Console.WriteLine($"Nombres de Bois en stock: ");
            Console.WriteLine($"Nombres de Silex en stock: ");
            Console.WriteLine($"Nombres d'Argiles en stock: ");
            Console.WriteLine($"Nombres d'Herbes en stock: ");
            Console.WriteLine($"Nombres de Sable en stock: ");
            Console.WriteLine("\t\t***********************************");
        }

        public static void DisplayInventoryMenu2()
        {
            Console.Clear();
            Display.DisplayInventoryItem2();
            Console.WriteLine();

            Console.WriteLine("\t\t**********************************");
            Console.WriteLine($"Nombres de Feu en stock: ");
            Console.WriteLine($"Nombres de Haches en stock: ");
            Console.WriteLine($"Nombres de Vitre en stock: ");
            Console.WriteLine($"Nombres de Planche en stock: ");
            Console.WriteLine($"Nombres de Briques en stock: ");
            Console.WriteLine($"Nombres d'Isolants en stock: ");
            Console.WriteLine($"Nombres de Maisons en stock: ");
            Console.WriteLine("\t\t**********************************");
        }
    }
}
