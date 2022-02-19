using System;

namespace SodaMachine
{
    static class UserInterface
    {
        
        public static void MainMenu()
        { 
            Console.Clear();
            Console.WriteLine(@"
            ╬═══════════════════════════════════════════╬
            ║  Select an item for more info, or insert  ║
            ║            cash or credit card.           ║
            ╬═══════════════════════════════════════════╬
            ");

        }

        public static void Choices()
        {
            Console.WriteLine(@"
            Input 'i' : Get info about products.
            Input 'b' : Purchase a soda.
            Input 'w' : View wallet.
            ");
        }


        public static void LineBreak()
        {
            Console.WriteLine("------------------------");
        }

    }
} 

