using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvieEnTerreInconnue
{
    internal class Display
    {
        public static string art = "";
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
        public static void DisplayDesert()
        {
            Console.WriteLine("           ,                        '           .        '        ,  " +
                "\r\n   .            .        '       .         ,         " +
                "\r\n                                                   .       '     +" +
                "\r\n       +          .-'''''-.     " +
                "\r\n                .'         `.   +     .     ________||" +
                "\r\n       ___     :             :     |       /        ||  .     '___" +
                "\r\n  ____/   \\   :               :   ||.    _/      || ||\\_______/   " +
                "\\\r\n /         \\  :      _/|      :   `|| __/      ,.|| ||             " +
                "\\\r\n/  ,   '  . \\  :   =/_/      :     |'_______     || ||  ||   .      " +
                "\\\r\n    |        \\__`._/ |     .'   ___|        \\__   \\\\||  ||...    ,   " +
                "\\\r\n   l|,   '   (   /  ,|...-'        \\   '   ,     __\\||_//___          " +
                "\r\n ___|____     \\_/^\\/||__    ,    .  ,__             ||//    \\    .  ," +
                "\r\n           _/~  `\"\"~`\"` \\_           ''(       ....,||/       '   " +
                "\r\n ..,...  __/  -'/  `-._ `\\_\\__        | \\           ||  _______   ." +
                "\r\n   itz/jgs/ccm'`  `\\   \\  \\-.\\        /(_1_,..      || /" +
                "\r\n                                            ______/" +
                "\"\"\"\"");
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
        public static void DisplayRiver()
        {
            Console.WriteLine("                  _.._" +
                "\r\n   _________....-~    ~-.______" +
                "\r\n~~~                            ~~~~-----...___________..--------" +
                "\r\n                                           |   |     |" +
                "\r\n                                           | |   |  ||" +
                "\r\n                                           |  |  |   |" +
                "\r\n                                           |'. .' .`.|" +
                "\r\n___________________________________________|0oOO0oO0o|____________" +
                "\r\n -          -         -       -      -    / '  '. ` ` \\    -    -" +
                "\r\n      --                  --       --   /    '  . `   ` \\    --" +
                "\r\n---            ---          ---       /  '                \\ ---" +
                "\r\n     ----               ----        /       ' ' .    ` `    \\  ----" +
                "\r\n-----         -----         ----- /   '   '        `      `   " +
                "\\\r\n     .-~~-.          ------     /          '    . `     `    `  " +
                "\\\r\n    (_^..^_)-------           /  '    '      '      `");
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
        public static void DisplayPrairie()
        {
            Console.WriteLine("        wWWWw               wWWWw                                  ");
            Console.WriteLine("   vVVVv (___) wWWWw         (___)  vVVVv                          ");
            Console.WriteLine("   (___)  ~Y~  (___)  vVVVv   ~Y~   (___)                          ");
            Console.WriteLine("    ~Y~   \\|    ~Y~   (___)    |/    ~Y~                          ");
            Console.WriteLine("    \\|   \\ |/   \\| /  \\~Y~/   \\|    \\ |/                      ");
            Console.WriteLine("   \\\\|// \\\\|// \\\\|/// \\\\|//  \\\\|// \\\\\\|///            ");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("___________________________________________________________________________");
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
        public static void DisplayForest()
        {
            Console.WriteLine("       ^            ^            ^            ^            ^       ");
            Console.WriteLine("      ^^^          ^^^          ^^^          ^^^          ^^^      ");
            Console.WriteLine("     ^^^^^        ^^^^^        ^^^^^        ^^^^^        ^^^^^     ");
            Console.WriteLine("    ^^^^^^^      ^^^^^^^      ^^^^^^^      ^^^^^^^      ^^^^^^^    ");
            Console.WriteLine("   ^^^^^^^^^    ^^^^^^^^^    ^^^^^^^^^    ^^^^^^^^^    ^^^^^^^^^   ");
            Console.WriteLine("      |||          |||          |||          |||          |||      ");
            Console.WriteLine("      |||          |||          |||          |||          |||      ");
            Console.WriteLine("  vvvv|||vvvv  vvvv|||vvvv  vvvv|||vvvv  vvvv|||vvvv  vvvv|||vvvv  ");
            Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");
            Console.WriteLine("______________________________________________________________________");
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
        public static void DisplaySwamp()
        {
            Console.WriteLine("    |           |       |              |         |          |      ");
            Console.WriteLine("    |           |       |              |         |          |      ");
            Console.WriteLine("    |     |     |   |   |      |       |    |    |     |    |      ");
            Console.WriteLine("  .-|-.   |   .-|-..|..-|-.  .-|-.   .-|-.  |  .-|-.   |  .-|-.    ");
            Console.WriteLine(" /  |  \\ | \\ /  | / | /  | \\/  | \\ /  | \\ | \\/  | \\ | \\/  | \\   ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~ @ ~~~~ @ ~~~~~ @ ~~~ @ ~~~~~ @ ~~~~ @ ~~~~ @ ~~~~ @ ~~~~~ @ ~~~~ @ ~~");
            Console.WriteLine("~~~~ @ ~~~~~ @ ~~~~ @ ~~~~~ @ ~~~~ @ ~~~~~ @ ~~~~ @ ~~~~~ @ ~~~~ @ ~~~~~");
            Console.WriteLine("~~ @ ~~~~ @ ~~~~~ @ ~~~ @ ~~~~~ @ ~~~~ @ ~~~~ @ ~~~~ @ ~~~~~ @ ~~~~ @ ~~");
            Console.WriteLine("___________________________________________________________________________");
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
        public static void DisplayMountain()
        {
            Console.WriteLine("     _    .  ,   .           ." +
                "\r\n    *  / \\_ *  / \\_      _  *        *   /\\'__        *" +
                "\r\n      /    \\  /    \\,   ((        .    _/  /  \\  *'." +
                "\r\n .   /\\/\\  /\\/ :' __ \\_  `          _^/  ^/    `--." +
                "\r\n    /    \\/  \\  _/  \\-'\\      *    /.' ^_   \\_   .'\\  *" +
                "\r\n  /\\  .-   `. \\/     \\ /==~=-=~=-=-;.  _/ \\ -. `_/   " +
                "\\\r\n /  `-.__ ^   / .-'.--\\ =-=~_=-=~=^/  _ `--./ .-'  `-" +
                "\r\n/jgs     `.  / /       `.~-^=-=~=^=.-'      '-._ `._");
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
    }
}
    

