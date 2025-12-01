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
        public static void DisplayGameTitle()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Display.AnimateText("███████╗██╗   ██╗██████╗ ██╗   ██╗██╗███████╗    ███████╗███╗   ██╗    ████████╗███████╗██████╗ ██████╗ ███████╗" +
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
                                "\r\n╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝                                             ", ConsoleColor.White, 1);
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("\n\nAppuyez sur touche pour commençer le jeu....");

            Console.ReadKey();
        }
        public static void StartGameIsland()
        {
            Console.WriteLine("                                                    ____" +
                "\r\n                                         v        _(    )" +
                "\r\n        _ ^ _                          v         (___(__)" +
                "\r\n       '_\\V/ `\r\n       ' oX`\r\n          X                            v" +
                "\r\n          X             -HELP!\r\n          X                                                 ." +
                "\r\n          X        \\O/                                      |" +
                "\\\r\n          X.a##a.   M                                       |_" +
                "\\\r\n       .aa########a.>>                                    __|__" +
                "\r\n    .a################aa.                                 \\   /" +
                "\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public static void DisplayPrincipalMenu()
        {
            Console.Clear();
            Console.WriteLine("███╗   ███╗███████╗███╗   ██╗██╗   ██╗       " +
                        "\r\n████╗ ████║██╔════╝████╗  ██║██║   ██║       " +
                        "\r\n██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║       " +
                        "\r\n██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║      " +
                        " \r\n██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝      " +
                        " \r\n╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝        ");
        }

        public static void DisplayGoodByeMessage()
        {
            Console.Clear();
            Display.AnimateText(" █████╗ ██╗   ██╗    ██████╗ ███████╗██╗   ██╗ ██████╗ ██╗██████╗ ██╗" +
                                "\r\n██╔══██╗██║   ██║    ██╔══██╗██╔════╝██║   ██║██╔═══██╗██║██╔══██╗██║" +
                                "\r\n███████║██║   ██║    ██████╔╝█████╗  ██║   ██║██║   ██║██║██████╔╝██║" +
                                "\r\n██╔══██║██║   ██║    ██╔══██╗██╔══╝  ╚██╗ ██╔╝██║   ██║██║██╔══██╗╚═╝" +
                                "\r\n██║  ██║╚██████╔╝    ██║  ██║███████╗ ╚████╔╝ ╚██████╔╝██║██║  ██║██╗" +
                                "\r\n╚═╝  ╚═╝ ╚═════╝     ╚═╝  ╚═╝╚══════╝  ╚═══╝   ╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝");
        }
        public static void DisplayCreditMessage()
        {
            Console.Clear();
            Console.WriteLine(" ██████╗██████╗ ███████╗██████╗ ██╗████████╗       " +
                            "\r\n██╔════╝██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝       " +
                            "\r\n██║     ██████╔╝█████╗  ██║  ██║██║   ██║          " +
                            "\r\n██║     ██╔══██╗██╔══╝  ██║  ██║██║   ██║          " +
                            "\r\n╚██████╗██║  ██║███████╗██████╔╝██║   ██║          " +
                            "\r\n ╚═════╝╚═╝  ╚═╝╚══════╝╚═════╝ ╚═╝   ╚═╝          ");
        }
        //Afficher la position de base 
        public static void DisplayBasePosition()
        {
            Console.Clear();
            Console.WriteLine("██████╗  █████╗ ███████╗███████╗" +
                        "\r\n██╔══██╗██╔══██╗██╔════╝██╔════╝" +
                        "\r\n██████╔╝███████║███████╗█████╗" +
                        "  \r\n██╔══██╗██╔══██║╚════██║██╔══╝ " +
                        " \r\n██████╔╝██║  ██║███████║███████╗" +
                        "\r\n╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝");
            Console.ResetColor();
        }

        //Afficher la position dans le désert
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

        //Afficher la position dans la rivière
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

        //Afficher la position dans la forêt
        public static void DisplayForestPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("███████╗ ██████╗ ██████╗ ███████╗████████╗" +
                        "\r\n██╔════╝██╔═══██╗██╔══██╗██╔════╝╚══██╔══╝" +
                        "\r\n█████╗  ██║   ██║██████╔╝█████╗     ██║  " +
                        " \r\n██╔══╝  ██║   ██║██╔══██╗██╔══╝     ██║   " +
                        "\r\n██║     ╚██████╔╝██║  ██║███████╗   ██║   " +
                        "\r\n╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝   ╚═╝   ");
            Console.ResetColor();
        }

        //Afficher la postion dans le marais
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

        //Afficher la postion dans les montagnes
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

        //Afficher l'inventaire
        public static void DisplayInventoryItems()
        {
            Console.WriteLine("██╗███╗   ██╗██╗   ██╗███████╗███╗   ██╗████████╗ █████╗ ██╗██████╗ ███████╗" +
                        "\r\n██║████╗  ██║██║   ██║██╔════╝████╗  ██║╚══██╔══╝██╔══██╗██║██╔══██╗██╔════╝" +
                        "\r\n██║██╔██╗ ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ███████║██║██████╔╝█████╗  " +
                        "\r\n██║██║╚██╗██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██╔══██║██║██╔══██╗██╔══╝  " +
                        "\r\n██║██║ ╚████║ ╚████╔╝ ███████╗██║ ╚████║   ██║   ██║  ██║██║██║  ██║███████╗" +
                        "\r\n╚═╝╚═╝  ╚═══╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚═╝  ╚═╝╚══════╝");
            Console.ResetColor();
        }
        public static void DisplayInventoryItem2()
        {
            Console.WriteLine("███╗   ███╗ █████╗ ████████╗███████╗██████╗ ██╗███████╗██╗   ██╗██╗  ██╗" +
                        "\r\n████╗ ████║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██║██╔════╝██║   ██║╚██╗██╔╝" +
                        "\r\n██╔████╔██║███████║   ██║   █████╗  ██████╔╝██║█████╗  ██║   ██║ ╚███╔╝" +
                        " \r\n██║╚██╔╝██║██╔══██║   ██║   ██╔══╝  ██╔══██╗██║██╔══╝  ██║   ██║ ██╔██╗ " +
                        "\r\n██║ ╚═╝ ██║██║  ██║   ██║   ███████╗██║  ██║██║███████╗╚██████╔╝██╔╝ ██╗" +
                        "\r\n╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝");
            Console.ResetColor();
        }
        public static void DisplayInventoryItem1()
        {
            Console.WriteLine("██████╗ ███████╗███████╗███████╗ ██████╗ ██╗   ██╗██████╗  ██████╗███████╗███████╗" +
                                "\r\n██╔══██╗██╔════╝██╔════╝██╔════╝██╔═══██╗██║   ██║██╔══██╗██╔════╝██╔════╝██╔════╝" +
                                "\r\n██████╔╝█████╗  ███████╗███████╗██║   ██║██║   ██║██████╔╝██║     █████╗  ███████╗" +
                                "\r\n██╔══██╗██╔══╝  ╚════██║╚════██║██║   ██║██║   ██║██╔══██╗██║     ██╔══╝  ╚════██║" +
                                "\r\n██║  ██║███████╗███████║███████║╚██████╔╝╚██████╔╝██║  ██║╚██████╗███████╗███████║" +
                                "\r\n╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚══════╝╚══════╝");
            Console.ResetColor();
        }
        //Afficher l'inventaire
        public static void DisplayManufacturingItems()
        {
            Console.WriteLine("███████╗ █████╗ ██████╗ ██████╗ ██╗ ██████╗ █████╗ ████████╗██╗ ██████╗ ███╗   ██╗" +
                                "\r\n██╔════╝██╔══██╗██╔══██╗██╔══██╗██║██╔════╝██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║" +
                                "\r\n█████╗  ███████║██████╔╝██████╔╝██║██║     ███████║   ██║   ██║██║   ██║██╔██╗ ██║" +
                                "\r\n██╔══╝  ██╔══██║██╔══██╗██╔══██╗██║██║     ██╔══██║   ██║   ██║██║   ██║██║╚██╗██║" +
                                "\r\n██║     ██║  ██║██████╔╝██║  ██║██║╚██████╗██║  ██║   ██║   ██║╚██████╔╝██║ ╚████║" +
                                "\r\n╚═╝     ╚═╝  ╚═╝╚═════╝ ╚═╝  ╚═╝╚═╝ ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝");
            Console.ResetColor();
        }
        public static void DisplayHouse()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

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

        // Monsieur Kevin m'a aidé à faire ce bout de code (fonction) parce que la méthode précédente ne marchait pas très bien avec les Ascii Art,il a juste améliorer AnimateText()
        public static void AnimateText(string texte, ConsoleColor couleur = ConsoleColor.White, int timeLimit = 30)
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

        public static void DisplayPlaneCrash()
        {
            Console.WriteLine(
                "\r\n                                       |" +
                "\r\n                                       |" +
                "\r\n                                     .-'-." +
                "\r\n                                    ' ___ '" +
                "\r\n                          ---------'  .-.  '---------" +
                "\r\n          _________________________'  '-'  '_________________________" +
                "\r\n           ''''''-|---|--/    \\==][^',_m_,'^][==/    \\--|---|-''''''" +
                "\r\n                         \\    /  ||/   H   \\||  \\    /" +
                "\r\n                          '--'   OO   O|O   OO   '--'");
        }
        public static void DisplaySnowFall()
        {
            Console.WriteLine(".      *    *           *.       *   .                      *     ." +
                "\r\n               .   .                   __   *    .     * .     *" +
                "\r\n    *       *         *   .     .    _|__|_        *    __   .       *" +
                "\r\n  .  *  /\\       /\\          *        ('')    *       _|__|_     ." +
                "\r\n       /  \\   * /  \\  *          .  <( . )> *  .       ('')   *   *" +
                "\r\n  *    /  \\     /  \\   .   *       _(__.__)_  _   ,--<(  . )>  .    ." +
                "\r\n      /    \\   /    \\          *   |       |  )),`   (   .  )     *" +
                "\r\n   *   `||` ..  `||`   . *.   ... ==========='`   ... '--`-` ... * jb .");
        }

        public static void DisplayRules()
        {
            Console.WriteLine("██████╗ ███████╗ ██████╗ ██╗     ███████╗███████╗" +
                        "\r\n██╔══██╗██╔════╝██╔════╝ ██║     ██╔════╝██╔════╝" +
                        "\r\n██████╔╝█████╗  ██║  ███╗██║     █████╗  ███████╗" +
                        "\r\n██╔══██╗██╔══╝  ██║   ██║██║     ██╔══╝  ╚════██║" +
                        "\r\n██║  ██║███████╗╚██████╔╝███████╗███████╗███████║" +
                        "\r\n╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚══════╝");
        }
        public static void DisplayCooking()
        {
            Console.WriteLine("██████╗ ███████╗██████╗  █████╗ ███████╗" +
                        "\r\n██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔════╝" +
                        "\r\n██████╔╝█████╗  ██████╔╝███████║███████╗" +
                        "\r\n██╔══██╗██╔══╝  ██╔═══╝ ██╔══██║╚════██║" +
                        "\r\n██║  ██║███████╗██║     ██║  ██║███████║" +
                        "\r\n╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝  ╚═╝╚══════╝");
        }
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
            else if(Map.playerEnergy <= 50 && Map.playerEnergy > 20)
            {
                barColor= ConsoleColor.Red;
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
        public static void DisplayGameOver()
        {
            Console.WriteLine("██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ " +
                        "\r\n██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗" +
                        "\r\n██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝" +
                        "\r\n██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗" +
                        "\r\n╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║" +
                        "\r\n ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝");
        }
        public static void DisplayLoseMessage()
        {
            DisplayGameOver();
            Console.WriteLine();
           
            ProcessNewGameConfirmation();
        }
        public static ConsoleKey DisplayNewGameConfirmation()
        {
            Console.Clear();
            Console.WriteLine("Voulez vous rejouer une nouvelle partie ?");
            Console.WriteLine("[O]ui");
            Console.WriteLine("[N]on");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            return keyInfo.Key;
        }

        public static void ProcessNewGameConfirmation()
        {
            bool waitingForChoice = true;
            while (waitingForChoice)
            {
                ConsoleKey input = DisplayNewGameConfirmation();
                switch (input)
                {
                    case ConsoleKey.O:
                        Map.ResetGame();
                        Map.ShowTerrainAtCurrentPosition();
                        waitingForChoice = false;
                        break;
                    case ConsoleKey.N:
                        waitingForChoice = false;
                        Console.WriteLine("Appuyer sur une touche pour quitter le jeu ...");
                        Console.ReadKey();
                        Process.GetCurrentProcess().Kill();
                        break;
                    default:
                        Console.WriteLine("\nChoix invalide. Veuillez réessayer");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}

    

