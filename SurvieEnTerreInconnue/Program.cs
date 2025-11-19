namespace SurvieEnTerreInconnue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display.DisplayGameTitle();
            Console.Clear();
            Menu.DisplayGameHistory();
            Console.Clear();
            Menu.DisplayStartMessage();
            Console.Clear();
            Menu.ProcessDisplayMenuInput();
        }
    }
}