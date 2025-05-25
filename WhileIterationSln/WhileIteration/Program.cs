using System.Globalization;

namespace WhileIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        private static void  MainMenu()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Option 1 ");
            Console.WriteLine("2) Option 2 ");
            Console.WriteLine("3) Option 3");
            string result = Console.ReadLine();

            if (result == " 1")
            
            {
                PrintNumbers ();
            }
            else if (result == "2")
            {
                GuessingGame();
            }
            else if (result == "3")
            {

            }
            else
            {
                 
            }
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("Print Numbers");
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.WriteLine("Guessing Game!");
            Console.ReadLine ();
        }

    }
}
