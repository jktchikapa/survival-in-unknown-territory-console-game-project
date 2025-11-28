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
            Console.WriteLine("███╗   ███╗███████╗███╗   ██╗██╗   ██╗       " +
                        "\r\n████╗ ████║██╔════╝████╗  ██║██║   ██║       " +
                        "\r\n██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║       " +
                        "\r\n██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║      " +
                        " \r\n██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝      " +
                        " \r\n╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝        ");
        }
      
        public static void DisplayGoodByeMessage()
        {
            Display.AnimateText(" █████╗ ██╗   ██╗    ██████╗ ███████╗██╗   ██╗ ██████╗ ██╗██████╗ ██╗" +
                                "\r\n██╔══██╗██║   ██║    ██╔══██╗██╔════╝██║   ██║██╔═══██╗██║██╔══██╗██║" +
                                "\r\n███████║██║   ██║    ██████╔╝█████╗  ██║   ██║██║   ██║██║██████╔╝██║" +
                                "\r\n██╔══██║██║   ██║    ██╔══██╗██╔══╝  ╚██╗ ██╔╝██║   ██║██║██╔══██╗╚═╝" +
                                "\r\n██║  ██║╚██████╔╝    ██║  ██║███████╗ ╚████╔╝ ╚██████╔╝██║██║  ██║██╗" +
                                "\r\n╚═╝  ╚═╝ ╚═════╝     ╚═╝  ╚═╝╚══════╝  ╚═══╝   ╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝");
        }
        public static void DisplayCreditMessage()
        {
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
            Console.WriteLine("██████╗  █████╗ ███████╗███████╗" +
                        "\r\n██╔══██╗██╔══██╗██╔════╝██╔════╝" +
                        "\r\n██████╔╝███████║███████╗█████╗" +
                        "  \r\n██╔══██╗██╔══██║╚════██║██╔══╝ " +
                        " \r\n██████╔╝██║  ██║███████║███████╗" +
                        "\r\n╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝");
            Console.ResetColor();
        }
        public static void DisplayBase()
        {
            Console.WriteLine("      _______________________________________________________        ");
            Console.WriteLine("     /\\                                                      \\       ");
            Console.WriteLine(" (O)===)><><><><><><><><><><><><><><><><><><><><><><><><><><><)==(O)");
            Console.WriteLine("     \\/''''''''''''''''''''''''''''''''''''''''''''''''''''''/      ");
            Console.WriteLine("     (                                                      (       ");
            Console.WriteLine("      )                                                      )      ");
            Console.WriteLine("     (                  TERRAIN DE BASE                    (       ");
            Console.WriteLine("      )                                                      )      ");
            Console.WriteLine("     (               Vous êtes au point de départ          (       ");
            Console.WriteLine("      )                                                      )      ");
            Console.WriteLine("     (           Choisissez votre prochaine direction      (       ");
            Console.WriteLine("      )                                                      )      ");
            Console.WriteLine("     (                                                      (       ");
            Console.WriteLine("      )                                                      )      ");
            Console.WriteLine("     (                                                      (       ");
            Console.WriteLine("      )                                                      )      ");
            Console.WriteLine("     /\\'''''''''''''''''''''''''''''''''''''''''''''''''''''\\      ");
            Console.WriteLine(" (O)===)><><><><><><><><><><><><><><><><><><><><><><><><><><><)==(O)");
            Console.WriteLine("     \\/______________________________________________________/       ");
        }
        //Afficher la position dans le désert
        public static void DisplayDesertPosition()
        {
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
            Console.WriteLine("             /||\\                                                   ");
            Console.WriteLine("             ||||                                                   ");
            Console.WriteLine("             |||| _____.-..-.                                       ");
            Console.WriteLine("             |||| /|\\ .-~@@/ / qp \\                               ");
            Console.WriteLine("        /|\\ |||| ||| .'@ _@/..\\-.__.-/                            ");
            Console.WriteLine("        ||| |||| ||| /@.-~/|~~`\\|__|/                              ");
            Console.WriteLine("        ||| |||| ||| |'--<|| '~~'                                  ");
            Console.WriteLine("        ||| |||| d|| |>--<\\@\\                                     ");
            Console.WriteLine("        ||| |||||||/ \\>---<\\@`\\.                                  ");
            Console.WriteLine("        ||b._||||~~'  `\\>---<`\\`\\.                                ");
            Console.WriteLine("        \\||||||||     `\\>----`\\@`\\.                               ");
            Console.WriteLine("         `~~~||||  _   `\\>-----`\\@`\\.                             ");
            Console.WriteLine("             |||| (_)   `\\>-----<`\\.`\\.                           ");
            Console.WriteLine("             |||| (_)    `\\>------`\\.@`\\.                         ");
            Console.WriteLine("             ||||              (__)        `\\>-------<`\\.`\\       ");
            Console.WriteLine("  .    ..  . |||| .  . ..    ( _)   ..        ..    .  `\\  .  .   ");
            Console.WriteLine(".  .  .  .  /    \\  .    \\      /  .    \\      /  .    \\  .  .   ");
            Console.WriteLine("   .    ..\\/ .... \\.. |   \\    /   \\    /    \\    /   |  .       ");
            Console.WriteLine("        .    |        \\  /      \\  /      \\  /        |  .        ");
            Console.WriteLine(".    .    ~            \\/        \\/        \\/            ~   .    ");
            Console.WriteLine("___________________________________________________________________________");
        }
        //Afficher la position dans la rivière
        public static void DisplayRiverPosition()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████╗ ██╗██╗   ██╗██╗███████╗██████╗ ███████╗" +
                        "\r\n██╔══██╗██║██║   ██║██║██╔════╝██╔══██╗██╔════╝" +
                        "\r\n██████╔╝██║██║   ██║██║█████╗  ██████╔╝█████╗ " +
                        " \r\n██╔══██╗██║╚██╗ ██╔╝██║██╔══╝  ██╔══██╗██╔══╝  " +
                        "\r\n██║  ██║██║ ╚████╔╝ ██║███████╗██║  ██║███████╗" +
                        "\r\n╚═╝  ╚═╝╚═╝  ╚═══╝  ╚═╝╚══════╝╚═╝  ╚═╝╚══════╝");
            Console.ResetColor();
        }
        public static void DisplayRiver()
        {
            Console.WriteLine("                  _____,,,\\//,,\\\\,/,                              ");
            Console.WriteLine("                 /------------- -----                              ");
            Console.WriteLine("                ///-------------  ----                             ");
            Console.WriteLine("               o////- ----------- --                               ");
            Console.WriteLine("               !!//o/---  -------                                  ");
            Console.WriteLine("             o*) !///,~,,\\\\,\\/,,/,//,,                          ");
            Console.WriteLine("               o!*!o'(\\          /\\                              ");
            Console.WriteLine("             | ! o \",) \\/\\  /\\  /  \\/\\                        ");
            Console.WriteLine("            o  !o! !!|    \\/  \\/     /                           ");
            Console.WriteLine("           ( * (  o!'; |\\   \\       /                            ");
            Console.WriteLine("            o o ! * ` | \\  /       \\                             ");
            Console.WriteLine("           o  |  o 'o| | :  \\       /                            ");
            Console.WriteLine("            *  o !*!': |o|  /      /                              ");
            Console.WriteLine("                (o''| `| : /      /                               ");
            Console.WriteLine("                ! *|`  \\|/       \\\\                             ");
            Console.WriteLine("               ' !o!':\\  \\\\        \\                           ");
            Console.WriteLine("                ( ('|  \\  `._______/                             ");
            Console.WriteLine("~~~~\\\\\\~~\\~~~~~~~\\~oO._*  o !*!`  `.________/                ");
            Console.WriteLine("  ~~~~ ~~ ~~~~~~~ ~~oO*OoOo (o''|           /                     ");
            Console.WriteLine("    ~~~~~~~~  ~~~~~~ 'oO*OoO!*|'o!!          \\                   ");
            Console.WriteLine("~~~~~~~  ~~~~~~~~~ ~~* oO*OoO *!'| '         /                    ");
            Console.WriteLine(" ~~~  ~   ~~~~~  ~~~~~~~ oO*OoO!!':o!'       /                    ");
            Console.WriteLine(" ~ ~  ~~~~~  ~  ~~  ~ *~~oO*OoOo!`         /                      ");
            Console.WriteLine("___________________________________________________________________________");
        }
        public static void DisplayPrairiePosition()
        {
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
            Console.WriteLine("                   ^         ^                   ^                 ");
            Console.WriteLine("       ^          ^^^       ^^^         ^       ^^^         ^      ");
            Console.WriteLine("      ^^^        ^^^^^     ^^^^^       ^^^     ^^^^^       ^^^     ");
            Console.WriteLine("     ^^^^^      ^^^^^^^   ^^^^^^^     ^^^^^   ^^^^^^^     ^^^^^    ");
            Console.WriteLine("    ^^^^^^^    ^^^^^^^^^ ^^^^^^^^^   ^^^^^^^  ^^^^^^^^   ^^^^^^^   ");
            Console.WriteLine("   ^^^^^^^^^      |||       |||    ^^^^^^^^^    |||    ^^^^^^^^^   ");
            Console.WriteLine("      |||         |||       |||       |||       |||       |||      ");
            Console.WriteLine("      |||         |||       |||       |||       |||       |||      ");
            Console.WriteLine("  vvvv|||vvvvvvvvv|||vvvvvvv|||vvvvvvv|||vvvvvvv|||vvvvvvv|||vvvvv");
            Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");
            Console.WriteLine("___________________________________________________________________________");
        }
        //Afficher la postion dans le marais
        public static void DisplaySwampPosition()
        {
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
            Console.WriteLine("                         _                                         ");
            Console.WriteLine("                        /#\\                                       ");
            Console.WriteLine("                       /###\\ /\\                                  ");
            Console.WriteLine("                      /###\\ /##\\ /\\                             ");
            Console.WriteLine("                     /#\\ /####\\/##\\                             ");
            Console.WriteLine("                    /#/ /#/ /##\\ _/\\                            ");
            Console.WriteLine("                  //// //\\ /_/ /#\\ _/#\\ _/##\\ /\\             ");
            Console.WriteLine("                 /// / /\\ /#\\ \\ _/###\\_ /##\\__/ _\\          ");
            Console.WriteLine("                /\\ / ..\\ / /_{ \\ \\ _/ /// / \\\\              ");
            Console.WriteLine("        /\\ / /\\ ...  \\_/ / /\\ } \\ | / /\\ \\ /_/ /\\ /\\      ");
            Console.WriteLine("     _ /\\ /// /.\\  ..%:. /... /\\ . \\ {: \\\\ /. \\ / \\ / ___ / \\");
            Console.WriteLine("    /.\\.\\.\\// \\/... \\.::::..... _/..\\ ..\\|:. . / ..\\\\ /..\\ /...\\ /\\ \\");
            Console.WriteLine("   /...\\.../..:.\\ ..:::::::..:..... . ...\\{:... /%...\\\\/..%.\\ /./:..\\_\\_\\");
            Console.WriteLine("  .:..\\..::.....:::;;;;;;::::::::.:::::.\\.}.....::%.:.\\ .:::.\\ /.%:::.:..\\");
            Console.WriteLine("  ::::...:::;;:::::;;;;;;;;;;;;;;:::::;;::{:::::::;;;:.. .:;:... ::;;::::.. ");
            Console.WriteLine("  ;;;;:::;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;];;;;;;;;;;::::::;;;;:.::;;;;;;;;;:..");
            Console.WriteLine("  ;;;;;;;;;;;;;;ii;;;;;;;;;;;;;;;;;;;;;;;;;[;;;;;;;;;;;;;;;;;;;;;;;:;;;;;;;;;;;;;;;");
            Console.WriteLine("  ;;;;;;;;;;;;;;;;;;;iiiiiii;;;;;;;;;;;;;;};;ii;;iiii;;;;i;;;;;;;;;;;;;;;ii;;;");
            Console.WriteLine("  iiii;;;iiiiiiiiiiIIIIIIIIIIIIiiiiiiIiiiiii{iiIIIiiiiiiiiiiiiiiiiii;;;;;iiiilliiiii");
            Console.WriteLine("  IIIiiiIIllllllIIllllIIIIlllIIIlIiiIIIIIIIIIIIIlIIIIllIIIIIIIiiiiiiiiiillIIIllII");
            Console.WriteLine("  IIIiiiilIIIIIIllTIIIIllIIlIlIIITTTTlIlIlIIIlIITTTTTTTIIIIlIIllIlIlllIIIIIIITT");
            Console.WriteLine("  IIIIilIIIIITTTTTTTIIIIIIIIIIIIITTTTTIIIIIIIIITTTTTTTTTTIIIIIIIIIlIIIIIIIIITTTT");
            Console.WriteLine("  IIIIIIIIITTTTTTTTTTTTTIIIIIIIITTTTTTTTTIIIIIITTTTTTTTTTTTTTTIIIIIIIIIIIIIITTTTT");
            Console.WriteLine("___________________________________________________________________________");
        }
        public static void DisplayDesert()
        {
            Console.WriteLine("             /||\\                                                   ");
            Console.WriteLine("             ||||                                                   ");
            Console.WriteLine("             |||| _____.-..-.                                       ");
            Console.WriteLine("             |||| /|\\ .-~@@/ / qp \\                               ");
            Console.WriteLine("        /|\\ |||| ||| .'@ _@/..\\-.__.-/                            ");
            Console.WriteLine("        ||| |||| ||| /@.-~/|~~`\\|__|/                              ");
            Console.WriteLine("        ||| |||| ||| |'--<|| '~~'                                  ");
            Console.WriteLine("        ||| |||| d|| |>--<\\@\\                                     ");
            Console.WriteLine("        ||| |||||||/ \\>---<\\@`\\.                                  ");
            Console.WriteLine("        ||b._||||~~'  `\\>---<`\\`\\.                                ");
            Console.WriteLine("        \\||||||||     `\\>----`\\@`\\.                               ");
            Console.WriteLine("         `~~~||||  _   `\\>-----`\\@`\\.                             ");
            Console.WriteLine("             |||| (_)   `\\>-----<`\\.`\\.                           ");
            Console.WriteLine("             |||| (_)    `\\>------`\\.@`\\.                         ");
            Console.WriteLine("~~~~~~~~~~~~~||||~~~~~~~~~~~~~~(__)~~~~~~~~`\\>-------<`\\.`\\~~~~~~~");
            Console.WriteLine("  \\/..__..--. |||| \\/ . ..____( _)@@@--..____\\..--\\@@@/~`\\@@>-._ \\/ .");
            Console.WriteLine("\\/ \\/ \\/ \\/ /--.-\\@@@@--@/---\\@@@/---\\@/--@@@@/-\\.--._        ");
            Console.WriteLine("   . \\/ _..\\/-...--.. |---\\@@/---\\@@@@/~~~~\\@@@@/---\\@@/---| .\\/");
            Console.WriteLine("        . \\/ |----@@----\\@@/-----\\@@/-----@@----|  .             ");
            Console.WriteLine(". \\/ . \\/ ~-..__------@@------@@------__.-~ . \\/                 ");
            Console.WriteLine("   __...--..__..__ . \\/ ~~~--..____------____..--~~~ \\/_..--..   ");
            Console.WriteLine("\\/ . . \\/ \\/ __..--... \\/ ~~~~~~~~~ \\/ . \\/ .                   ");
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
        /*
                  foreach (char c in texte)
                  {
                      Console.Write(c);
                      Thread.Sleep(timeLimit);
                  }

                  Console.ForegroundColor = savedColor;

                  */

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
    }
}
    

