using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvieEnTerreInconnue
{
    internal class Display
    {
        /// <summary>
        ///Méthode qui affiche le titre du jeu
        /// </summary>
        public static void DisplayGameTitle()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("███████╗██╗   ██╗██████╗ ██╗   ██╗██╗███████╗    ███████╗███╗   ██╗    ████████╗███████╗██████╗ ██████╗ ███████╗" +
                                "\r\n██╔════╝██║   ██║██╔══██╗██║   ██║██║██╔════╝    ██╔════╝████╗  ██║    ╚══██╔══╝██╔════╝██╔══██╗██╔══██╗██╔════╝" +
                                "\r\n███████╗██║   ██║██████╔╝██║   ██║██║█████╗      █████╗  ██╔██╗ ██║       ██║   █████╗  ██████╔╝██████╔╝█████╗ " +
                                " \r\n╚════██║██║   ██║██╔══██╗╚██╗ ██╔╝██║██╔══╝      ██╔══╝  ██║╚██╗██║       ██║   ██╔══╝  ██╔══██╗██╔══██╗██╔══╝  " +
                                "\r\n███████║╚██████╔╝██║  ██║ ╚████╔╝ ██║███████╗    ███████╗██║ ╚████║       ██║   ███████╗██║  ██║██║  ██║███████╗" +
                                "\r\n╚══════╝ ╚═════╝ ╚═╝  ╚═╝  ╚═══╝  ╚═╝╚══════╝    ╚══════╝╚═╝  ╚═══╝       ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝" +
                                "\r\n██╗███╗   ██╗ ██████╗ ██████╗ ███╗   ██╗███╗   ██╗██╗   ██╗███████╗                                             " +
                                "\r\n██║████╗  ██║██╔════╝██╔═══██╗████╗  ██║████╗  ██║██║   ██║██╔════╝                                             " +
                                "\r\n██║██╔██╗ ██║██║     ██║   ██║██╔██╗ ██║██╔██╗ ██║██║   ██║█████╗                                               " +
                                "\r\n██║██║╚██╗██║██║     ██║   ██║██║╚██╗██║██║╚██╗██║██║   ██║██╔══╝                                               " +
                                "\r\n██║██║ ╚████║╚██████╗╚██████╔╝██║ ╚████║██║ ╚████║╚██████╔╝███████╗                                             " +
                                "\r\n╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝                                             ");
            Console.WriteLine();
            Console.ResetColor();
            WaitForKeyPress("\n\nAppuyez sur touche pour commençer le jeu....");
            Thread.Sleep(200);
        }

        /// <summary>
        ///Méthode qui affiche "Menu"
        /// </summary>
        public static void DisplayPrincipalMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("███╗   ███╗███████╗███╗   ██╗██╗   ██╗       " +
                        "\r\n████╗ ████║██╔════╝████╗  ██║██║   ██║       " +
                        "\r\n██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║       " +
                        "\r\n██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║      " +
                        " \r\n██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝      " +
                        " \r\n╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝        ");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Crédit"
        /// </summary>
        public static void DisplayCreditMessage()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(" ██████╗██████╗ ███████╗██████╗ ██╗████████╗       " +
                            "\r\n██╔════╝██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝       " +
                            "\r\n██║     ██████╔╝█████╗  ██║  ██║██║   ██║          " +
                            "\r\n██║     ██╔══██╗██╔══╝  ██║  ██║██║   ██║          " +
                            "\r\n╚██████╗██║  ██║███████╗██████╔╝██║   ██║          " +
                            "\r\n ╚═════╝╚═╝  ╚═╝╚══════╝╚═════╝ ╚═╝   ╚═╝          ");
        }

        /// <summary>
        ///Méthode qui affiche "Base"
        /// </summary>
        public static void DisplayBasePosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("██████╗  █████╗ ███████╗███████╗" +
                        "\r\n██╔══██╗██╔══██╗██╔════╝██╔════╝" +
                        "\r\n██████╔╝███████║███████╗█████╗" +
                        "\r\n██╔══██╗██╔══██║╚════██║██╔══╝ " +
                        "\r\n██████╔╝██║  ██║███████║███████╗" +
                        "\r\n╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Désert"
        /// </summary>
        public static void DisplayDesertPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("██████╗ ███████╗███████╗███████╗██████╗ ████████╗" +
                                "\r\n██╔══██╗██╔════╝██╔════╝██╔════╝██╔══██╗╚══██╔══╝" +
                                "\r\n██║  ██║█████╗  ███████╗█████╗  ██████╔╝   ██║   " +
                                "\r\n██║  ██║██╔══╝  ╚════██║██╔══╝  ██╔══██╗   ██║   " +
                                "\r\n██████╔╝███████╗███████║███████╗██║  ██║   ██║   " +
                                "\r\n╚═════╝ ╚══════╝╚══════╝╚══════╝╚═╝  ╚═╝   ╚═╝   ");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Rivière"
        /// </summary>
        public static void DisplayRiverPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████╗ ██╗██╗   ██╗██╗███████╗██████╗ ███████╗" +
                        "\r\n██╔══██╗██║██║   ██║██║██╔════╝██╔══██╗██╔════╝" +
                        "\r\n██████╔╝██║██║   ██║██║█████╗  ██████╔╝█████╗  " +
                        "\r\n██╔══██╗██║╚██╗ ██╔╝██║██╔══╝  ██╔══██╗██╔══╝  " +
                        "\r\n██║  ██║██║ ╚████╔╝ ██║███████╗██║  ██║███████╗" +
                        "\r\n╚═╝  ╚═╝╚═╝  ╚═══╝  ╚═╝╚══════╝╚═╝  ╚═╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Prairie"
        /// </summary>
        public static void DisplayPrairiePosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("██████╗ ██████╗  █████╗ ██╗██████╗ ██╗███████╗" +
                        "\r\n██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗██║██╔════╝" +
                        "\r\n██████╔╝██████╔╝███████║██║██████╔╝██║█████╗  " +
                        "\r\n██╔═══╝ ██╔══██╗██╔══██║██║██╔══██╗██║██╔══╝  " +
                        "\r\n██║     ██║  ██║██║  ██║██║██║  ██║██║███████╗" +
                        "\r\n╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚═╝  ╚═╝╚═╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Forêt"
        /// </summary>
        public static void DisplayForestPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("███████╗ ██████╗ ██████╗ ███████╗████████╗" +
                        "\r\n██╔════╝██╔═══██╗██╔══██╗██╔════╝╚══██╔══╝" +
                        "\r\n█████╗  ██║   ██║██████╔╝█████╗     ██║  " +
                        " \r\n██╔══╝  ██║   ██║██╔══██╗██╔══╝     ██║   " +
                        "\r\n██║     ╚██████╔╝██║  ██║███████╗   ██║   " +
                        "\r\n╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝   ╚═╝   ");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Marais"
        /// </summary>
        public static void DisplaySwampPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("███╗   ███╗ █████╗ ██████╗  █████╗ ██╗███████╗" +
                                "\r\n████╗ ████║██╔══██╗██╔══██╗██╔══██╗██║██╔════╝" +
                                "\r\n██╔████╔██║███████║██████╔╝███████║██║███████╗" +
                                "\r\n██║╚██╔╝██║██╔══██║██╔══██╗██╔══██║██║╚════██║" +
                                "\r\n██║ ╚═╝ ██║██║  ██║██║  ██║██║  ██║██║███████║" +
                                "\r\n╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Montagne"
        /// </summary>
        public static void DisplayMountainPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("███╗   ███╗ ██████╗ ███╗   ██╗████████╗ █████╗  ██████╗ ███╗   ██╗███████╗" +
                        "\r\n████╗ ████║██╔═══██╗████╗  ██║╚══██╔══╝██╔══██╗██╔════╝ ████╗  ██║██╔════╝" +
                        "\r\n██╔████╔██║██║   ██║██╔██╗ ██║   ██║   ███████║██║  ███╗██╔██╗ ██║█████╗  " +
                        "\r\n██║╚██╔╝██║██║   ██║██║╚██╗██║   ██║   ██╔══██║██║   ██║██║╚██╗██║██╔══╝  " +
                        "\r\n██║ ╚═╝ ██║╚██████╔╝██║ ╚████║   ██║   ██║  ██║╚██████╔╝██║ ╚████║███████╗" +
                        "\r\n╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Inventaire"
        /// </summary>
        public static void DisplayInventoryItems()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("██╗███╗   ██╗██╗   ██╗███████╗███╗   ██╗████████╗ █████╗ ██╗██████╗ ███████╗" +
                        "\r\n██║████╗  ██║██║   ██║██╔════╝████╗  ██║╚══██╔══╝██╔══██╗██║██╔══██╗██╔════╝" +
                        "\r\n██║██╔██╗ ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ███████║██║██████╔╝█████╗  " +
                        "\r\n██║██║╚██╗██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██╔══██║██║██╔══██╗██╔══╝  " +
                        "\r\n██║██║ ╚████║ ╚████╔╝ ███████╗██║ ╚████║   ██║   ██║  ██║██║██║  ██║███████╗" +
                        "\r\n╚═╝╚═╝  ╚═══╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚═╝  ╚═╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Matériaux"
        /// </summary>
        public static void DisplayInventoryItem2()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("███╗   ███╗ █████╗ ████████╗███████╗██████╗ ██╗███████╗██╗   ██╗██╗  ██╗" +
                        "\r\n████╗ ████║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██║██╔════╝██║   ██║╚██╗██╔╝" +
                        "\r\n██╔████╔██║███████║   ██║   █████╗  ██████╔╝██║█████╗  ██║   ██║ ╚███╔╝" +
                        " \r\n██║╚██╔╝██║██╔══██║   ██║   ██╔══╝  ██╔══██╗██║██╔══╝  ██║   ██║ ██╔██╗ " +
                        "\r\n██║ ╚═╝ ██║██║  ██║   ██║   ███████╗██║  ██║██║███████╗╚██████╔╝██╔╝ ██╗" +
                        "\r\n╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Ressources"
        /// </summary>
        public static void DisplayInventoryItem1()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("██████╗ ███████╗███████╗███████╗ ██████╗ ██╗   ██╗██████╗  ██████╗███████╗███████╗" +
                                "\r\n██╔══██╗██╔════╝██╔════╝██╔════╝██╔═══██╗██║   ██║██╔══██╗██╔════╝██╔════╝██╔════╝" +
                                "\r\n██████╔╝█████╗  ███████╗███████╗██║   ██║██║   ██║██████╔╝██║     █████╗  ███████╗" +
                                "\r\n██╔══██╗██╔══╝  ╚════██║╚════██║██║   ██║██║   ██║██╔══██╗██║     ██╔══╝  ╚════██║" +
                                "\r\n██║  ██║███████╗███████║███████║╚██████╔╝╚██████╔╝██║  ██║╚██████╗███████╗███████║" +
                                "\r\n╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚══════╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Fabrication"
        /// </summary>
        public static void DisplayManufacturingItems()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("███████╗ █████╗ ██████╗ ██████╗ ██╗ ██████╗ █████╗ ████████╗██╗ ██████╗ ███╗   ██╗" +
                                "\r\n██╔════╝██╔══██╗██╔══██╗██╔══██╗██║██╔════╝██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║" +
                                "\r\n█████╗  ███████║██████╔╝██████╔╝██║██║     ███████║   ██║   ██║██║   ██║██╔██╗ ██║" +
                                "\r\n██╔══╝  ██╔══██║██╔══██╗██╔══██╗██║██║     ██╔══██║   ██║   ██║██║   ██║██║╚██╗██║" +
                                "\r\n██║     ██║  ██║██████╔╝██║  ██║██║╚██████╗██║  ██║   ██║   ██║╚██████╔╝██║ ╚████║" +
                                "\r\n╚═╝     ╚═╝  ╚═╝╚═════╝ ╚═╝  ╚═╝╚═╝ ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche la maison 
        /// </summary>
        public static void DisplayHouse()
        {
            string art = @"                                    /\
                               /\  //\\
                        /\    //\\///\\\        /\
                       //\\  ///\////\\\\  /\  //\\
          /\          /  ^ \/^ ^/^  ^  ^ \/^ \/  ^ \
         / ^\    /\  / ^   /  ^/ ^ ^ ^   ^\ ^/  ^^  \
        /^   \  / ^\/ ^ ^   ^ / ^  ^    ^  \/ ^   ^  \       *
       /  ^ ^ \/^  ^\ ^ ^ ^   ^  ^   ^   ____  ^   ^  \     /|\
      / ^ ^  ^ \ ^  _\___________________|  |_____^ ^  \   /||o\
     / ^^  ^ ^ ^\  /______________________________\ ^ ^ \ /|o|||\
    /  ^  ^^ ^ ^  /________________________________\  ^  /|||||o|\
   /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\
  / ^   ^   ^    ^  ||___|___||||||||||||___|__|||          | |
 / ^ ^ ^  ^  ^  ^   ||||||||||||||||||||||||||||||oooooooooo| |ooooooo
 ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo"
            ;
            Console.WriteLine(art);
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Base"
        /// </summary>
        public static void AnimateText(string texte, ConsoleColor couleur = ConsoleColor.White, int timeLimit = 25)
        {
            ConsoleColor savedColor = Console.ForegroundColor;
            Console.ForegroundColor = couleur;

            for (int i = 0; i < texte.Length; i++)
            {
                Console.Write(texte[i]);
                if (i % 2 == 0)
                {
                    Thread.Sleep(timeLimit);
                }
            }
            Console.ForegroundColor = savedColor;
        }

        /// <summary>
        ///Méthode qui affiche "Repas"
        /// </summary>
        public static void DisplayCooking()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("██████╗ ███████╗██████╗  █████╗ ███████╗" +
                        "\r\n██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔════╝" +
                        "\r\n██████╔╝█████╗  ██████╔╝███████║███████╗" +
                        "\r\n██╔══██╗██╔══╝  ██╔═══╝ ██╔══██║╚════██║" +
                        "\r\n██║  ██║███████╗██║     ██║  ██║███████║" +
                        "\r\n╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝  ╚═╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche la barre d'énergie
        /// </summary>
        public static void DisplayEnergyBar()
        {
            Console.Write("\nÉnergie: [");
            int barLength = 30;
            int filledBars = (Map.playerEnergy * barLength) / 100;

            ConsoleColor barColor = ConsoleColor.White;

            if (Map.playerEnergy > 75)
            {
                barColor = ConsoleColor.DarkGreen;
            }
            else if (Map.playerEnergy > 50)
            {
                barColor = ConsoleColor.Green;
            }
            else if (Map.playerEnergy <= 50 && Map.playerEnergy > 20)
            {
                barColor = ConsoleColor.Red;
            }
            else
            {
                barColor = ConsoleColor.DarkRed;
            }
            Console.ForegroundColor = barColor;
            for (int i = 0; i < filledBars; i++)
            {
                Console.Write("█");
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = filledBars; i < barLength; i++)
            {
                Console.Write("░");
            }
            Console.WriteLine($"] {Map.playerEnergy}%");
        }

        /// <summary>
        ///Méthode qui affiche "Game over"
        /// </summary>
        public static void DisplayGameOver()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ " +
                        "\r\n██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗" +
                        "\r\n██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝" +
                        "\r\n██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗" +
                        "\r\n╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║" +
                        "\r\n ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche le message lorsque le joueur a perdu la partie
        /// </summary>
        public static void DisplayLoseMessage()
        {
            DisplayGameOver();
            Console.WriteLine($"\n{Map.playerName}, vous avez perdu la partie car vous n'avez pas pu vous construire une maison avant l'hiver...");
            WaitForKeyPress("\n\nAppuyez sur une touche pour continuer...");
            Menu.ProcessNewGameConfirmation();
        }
        /// <summary>
        /// Méthode qui affiche le message d'aurevoir à l'utilisateur
        /// </summary>
        public static void DisplayGoodByeMessage()
        {
            Console.Clear();
            Console.ResetColor();
            AnimateText($"Au revoir {Map.playerName}! Merci d'avoir joué!");
            WaitForKeyPress("\n\nAppuyez sur une touche pour fermer le jeu...");
            Process.GetCurrentProcess().Kill();
        }

        /// <summary>
        ///Méthode qui affiche le message de confirmation d'une nouvelle partie
        /// </summary>
        public static ConsoleKey DisplayNewGameConfirmation()
        {
            Console.Clear();
            Console.WriteLine($"Voulez vous rejouer une nouvelle partie {Map.playerName}?");
            Console.WriteLine("\n[O]ui");
            Console.WriteLine("[N]on");

            ConsoleKeyInfo selectedAction = Console.ReadKey(true);
            return selectedAction.Key;
        }

        /// <summary>
        /// Méthode qui affiche l'inventaire des matériaux
        /// </summary>
        public static void DisplayInventoryMenu2()
        {
            Console.Clear();
            DisplayInventoryItem2();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t******************************************************");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[6]}".PadRight(20)}:{$"{Map.resourceAmounts[6].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[7]}".PadRight(20)}:{$"{Map.resourceAmounts[7].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[8]}".PadRight(20)}:{$"{Map.resourceAmounts[8].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[9]}".PadRight(20)}:{$"{Map.resourceAmounts[9].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[10]}".PadRight(20)}:{$"{Map.resourceAmounts[10].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[11]}".PadRight(20)}:{$"{Map.resourceAmounts[11].ToString()}".PadRight(28)}  *");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[12]}".PadRight(20)}:{$"{Map.resourceAmounts[12].ToString()}".PadRight(28)}  *");
            Console.WriteLine("\t\t******************************************************");
        }

        /// <summary>
        /// Méthode qui affiche l'inventaire des ressources
        /// </summary>
        public static void DisplayInventoryMenu1()
        {
            Console.Clear();
            DisplayInventoryItem1();
            Console.WriteLine();
            Console.WriteLine("\t\t*****************************************************");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[0]}".PadRight(20)}: {$"{Map.resourceAmounts[0].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[1]}".PadRight(20)}: {$"{Map.resourceAmounts[1].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[2]}".PadRight(20)}: {$"{Map.resourceAmounts[2].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[3]}".PadRight(20)}: {$"{Map.resourceAmounts[3].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[4]}".PadRight(20)}: {$"{Map.resourceAmounts[4].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[5]}".PadRight(20)}: {$"{Map.resourceAmounts[5].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[13]}".PadRight(20)}: {$"{Map.resourceAmounts[13].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[14]}".PadRight(20)}: {$"{Map.resourceAmounts[14].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[15]}".PadRight(20)}: {$"{Map.resourceAmounts[15].ToString()}".PadRight(28)}*");
            Console.WriteLine($"\t\t* {$"{Map.resourceNames[16]}".PadRight(20)}: {$"{Map.resourceAmounts[16].ToString()}".PadRight(28)}*");
            Console.WriteLine("\t\t*****************************************************");
        }

        /// <summary>
        /// Méthode qui affiche le menu d'inventaire principal
        /// </summary>
        public static ConsoleKey DisplayInventoryPrincipalMenu()
        {
            Console.Clear();
            DisplayInventoryItems();
            Console.WriteLine($"\nBienvenue dans l'inventaire du jeu {Map.playerName}");
            Console.WriteLine("\nDans cette section, vous pouvez consulter toutes les ressources et matériaux à votre disposition");
            Console.WriteLine("Veuillez sélectionner une option :");
            Console.WriteLine("\n[R]essources : Consultez les ressources que vous possédez");
            Console.WriteLine("[M]atériaux : Consulter les matériaux que vous avez fabriqué");
            Console.WriteLine("[E]xplorer ou continuer d'explorer les territoires");
            Console.WriteLine("[ESC]Retour au menu principal");
            Console.WriteLine("[Q]uitter l'inventaire");
            Console.WriteLine();
            AnimateText("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey(true);
            return selectedAction.Key;
        }

        /// <summary>
        /// Méthode qui affiche le menu de préparationb des aliments (poission et gibier)
        /// </summary>
        public static ConsoleKey DisplayCookingMenu()
        {
            Console.Clear();
            DisplayCooking();
            Console.WriteLine();
            Console.WriteLine($"Veuillez sélectionner l'aliments que vous souhaitez cuisiner {Map.playerName}:");
            Console.WriteLine("[P]oisson");
            Console.WriteLine("[G]ibier");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[E]xplorer ou continuer d'explorer les territoires");
            Console.WriteLine("[R]etour au menu de fabrication");
            Console.WriteLine("[ESC] Retour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.Write("\n\nVotre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey(true);
            return selectedAction.Key;
        }

        /// <summary>
        /// Méthode qui affiche le menu de fabrication
        /// </summary>
        public static ConsoleKey DisplayManufacturingMenu()
        {
            Console.Clear();
            DisplayManufacturingItems();
            Console.WriteLine();
            Console.WriteLine("\t********************************************************************************************************");
            Console.WriteLine($"\t* {"[F]eu".PadRight(10)}: Cette action nécessite du Bois et du Silex                                               *");
            Console.WriteLine($"\t* {"[H]ache".PadRight(10)}: Cette action nécessite du Bois et du Fer                                                 *");
            Console.WriteLine($"\t* {"[V]itre".PadRight(10)}: Cette action nécessite du Sable et du Feu                                                *");
            Console.WriteLine($"\t* {"[P]lanche".PadRight(10)}: Cette action nécessite du Bois ainsi qu'une Hache                                        *");
            Console.WriteLine($"\t* {"[B]rique".PadRight(10)}: Cette action nécessite du Feu et de l'Argile                                             *");
            Console.WriteLine($"\t* {"[I]solant".PadRight(10)}: Cette action nécessite 3x de l'Herbe                                                     *");
            Console.WriteLine($"\t* {"[M]aison".PadRight(10)}: Cette action nécessite 4x des Planches, 4x des Isolants, 4x des Briques et 2x des Vitres *");
            Console.WriteLine($"\t* {"[N]ouritture".PadRight(10)}: Cette action nécessite du Feu et du Bois                                               *");
            Console.WriteLine($"\t* {"[C]onsulter Inventaire".PadRight(10)}: Vous pouvez consulter votre inventaire                                       *");
            Console.WriteLine($"\t* {"[ESC]Retour au menu principal".PadRight(10)}                                                                        *");
            Console.WriteLine($"\t* {"[R]etour au terrain de base".PadRight(10)}                                                                          *");
            Console.WriteLine($"\t* {"[A]bandonner la fabrication de matériaux ".PadRight(10)}                                                            *");
            Console.WriteLine($"\t* {"[Q]uitter le jeu".PadRight(10)}                                                                                     *");
            Console.WriteLine("\t********************************************************************************************************");
            Console.Write("\n\nVotre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey(true);
            return selectedAction.Key;
        }

        /// <summary>
        /// Message qui s'affcihe lorsque l'utilisateur réussi à construre une maison
        /// </summary>
        public static void DisplayEndMessage()
        {
            DisplayHouse();
            Console.WriteLine($"\nFélicitations {Map.playerName}! Vous avez réussi à construire une maison qui vous protègera du froid hivernale. Profitez bien!");
            Process.GetCurrentProcess().Kill();
        }

        /// <summary>
        /// Méthode qui affiche la mise en contexte du jeu
        /// </summary>
        public static void DisplayGameHistory()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();
            Console.WriteLine(@"
                ??      ??     ??      ??  ??  ??
             ??    ??    ??   ??    ??      ??
                ??   ??     ??   ??      ??    ??
             ??      ??   ??   ⛺     ??    ??
                ??    ??   ??      ??     ??   ??
             ??   ??    ??      ??    ??     ??
                ??      ??     ??     ??   ??  ??
            ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
                      TERRE INCONNUE");


            AnimateText("\n\nVous vous réveillez après un crash d'avion ...");
            Thread.Sleep(100);
            AnimateText("\nL'hiver approche ... Construisez vous un abris avant qu'il ne soit trop tard ...");
            Thread.Sleep(900);
            AnimateText("\n\nQuel est votre nom, survivant ? ");
            Map.playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Bonne chance, {Map.playerName}...");
            WaitForKeyPress("\nAppuyez sur une touche pour continuer");
        }

        /// <summary>
        /// Méthode qui affiche les crédits du jeu
        /// </summary>
        public static void DisplayProgrammersCredits()
        {
            Console.Clear();
            DisplayCreditMessage();

            AnimateText("\n\nCe jeu a été développé par :");
            AnimateText("\n - Romuald Arnaud");
            AnimateText("\n - Jessica Karelle");

            AnimateText("\n\nNos améliorations :");
            AnimateText("\n - Plusieurs menus et interfaces pour l'utilisateur");
            AnimateText("\n - Système de probabilités de collecte de ressources");
            AnimateText("\n - Ajout d'émojis significatifs pour chaque terrain");
            AnimateText("\n - Ajout des choix Boire/Manger");
            AnimateText("\n - Ajout d'une barre d'énergie");
            AnimateText("\n - Personnalisation avec le nom du joueur");

            WaitForKeyPress("\n\nAppuyez sur une touche pour retourner au menu...");
        }
        /// <summary>
        /// Méthode qui affiche le menu quitter et se rassure que l'utilisateur n'a pas quitté le jeu par erreur
        /// </summary>
        public static ConsoleKey DisplayLeaveMessage()
        {
            Console.Clear();
            AnimateText($"Êtes vous sûr de vouloir quitter la partie {Map.playerName}?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n[O]ui, je souhaite quitter la partie");
            Console.ResetColor();
            Console.WriteLine("[N]on, je ne souhaite plus quitter la partie");
            Console.WriteLine("[S]auvegarder ma progression et quitter");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey(true);
            return selectedAction.Key;
        }
        /// <summary>
        /// Méthode qui affiche un message et attend qu'une touche soit pressée par l'utilisateur.
        /// </summary>
        public static void WaitForKeyPress(string message = "\nAppuyez sur une touche pour continuer...")
        {
            Console.WriteLine(message);
            Console.ReadKey(true);
        }

        /// <summary>
        /// Méthode qui affiche le menu principal du jeu
        /// </summary>
        public static ConsoleKey DisplayMenu()
        {
            Console.Clear();
            DisplayPrincipalMenu();
            Console.WriteLine();
            Console.WriteLine($"Veuillez sélectionner une action {Map.playerName} :");
            Console.WriteLine("[D]émarer une nouvelle partie");
            Console.WriteLine("[C]hargé une partie");
            Console.WriteLine("[S]auvegarder une partie");
            Console.WriteLine("[A]uteurs");
            if (Map.hasStartedGame)
            {
                Console.WriteLine("[Enter]Retourner au terrain actuel");
            }
            Console.WriteLine("[Q]uitter");

            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey(true);
            return selectedAction.Key;
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
            Console.WriteLine("[M]anger un fruit");
            Console.WriteLine("[B]oire de l'eau");
            Console.WriteLine("[ESC]Retour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Display.AnimateText("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey(true);
            return selectedAction.Key;
        }

        /// <summary>
        /// Méthode qui affiche le menu du terrain de base
        /// </summary>
        public static ConsoleKey DisplayBase()
        {
            Console.Clear();
            DisplayBasePosition();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Vous êtes actuellement sur le terrain de base");
            Console.WriteLine("Veuillez sélectionner une action à effectuer :\n");
            Console.ResetColor();
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[F]abriquer des matériaux");
            Console.WriteLine("[ESC]Retour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Display.AnimateText("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey(true);
            return selectedAction.Key;
        }

        /// <summary>
        /// Méthode qui permet d'afficher les informations générales (Position du joueur, déplacemnts, barre d'énergie et nombres de déplacemnts restants)
        /// </summary>
        public static ConsoleKey DisplayDirection()
        {
            Console.Clear();
            Map.DisplayGridMap();
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine($"Position de {Map.playerName}: ({Map.playerPositionX}, {Map.playerPositionY}) - {Map.GetCurrentTerrain()}");
            Console.WriteLine($"Nombre de déplacement(s) restant(s) : {Map.numberOfTripsRemaining}");
            DisplayEnergyBar();
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

            ConsoleKeyInfo selectedAction = Console.ReadKey(true);
            return selectedAction.Key;
        }
    }
}



