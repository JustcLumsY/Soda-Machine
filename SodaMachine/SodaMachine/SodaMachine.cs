using System;
using System.Collections.Generic;
using System.Threading;
using SodaMachine.Enums;
using SodaMachine.Interfaces;

namespace SodaMachine
{
    internal class SodaMachine
    {
        public Storage Storage;
      
        public MoneyHandler MoneyHandler;

        public SodaMachine()
        {
            Storage = new Storage();
   
            MoneyHandler = new MoneyHandler();
            Storage.InitializeDrinks();
        }

        void BuySodaList(List<IDrink> drinks)
        {
            Console.Clear();
            Console.WriteLine(@"
                ╬═══════════════════════════════════════════╬
                ║R = return | <Select a product>            ║
                ╬═══════════════════════════════════════════╬
            ");

            foreach (var i in drinks)
            {
                Console.WriteLine($"{i.Type}");
                Console.WriteLine($"Price: {i.Price} kr");
                Console.WriteLine($"Drink number: {(int)i.Type}");
                UserInterface.LineBreak();
            }
            // ReturnMainMenu(drinks);

            Console.WriteLine("<Select a drink number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (!Storage.CheckStorage((DrinkTypeEnum) userInput))
            {
                Console.WriteLine("Empty");
            }
            else
            {
                IDrink info = Storage.GetDrinkInfo((DrinkTypeEnum) userInput);
                if (MoneyHandler.HasEnoughMoney(info.Price))
                {
                    MoneyHandler.SpendMoney(info.Price);
                    IDrink drink = Storage.GetDrink((DrinkTypeEnum)userInput);
                }
                else
                {
                    Console.WriteLine("Not enough money, please Insert coins");
                    MoneyHandler.InsertCoin();
                    Console.WriteLine($"Coins inserted: {MoneyHandler.AmountOfMoney}");
                    Thread.Sleep(1500);
                    if (MoneyHandler.AmountOfMoney >= info.Price){ Console.WriteLine($"Thanks for buying {info.Type}"); }
                }
              // ReturnMainMenu(drinks);
            }
        }
        void InfoAboutProducts(List<IDrink> drinks)
        {
            Console.Clear();
            Console.WriteLine(@"
                ╬═══════════════════════════════════════════╬
                ║R = return|    <Product info>              ║
                ╬═══════════════════════════════════════════╬
            ");

            foreach (var drink in drinks)
            {
                Console.WriteLine($"{drink.Type} - {drink.Price}Kr" );
                UserInterface.LineBreak();
            }
            ReturnMainMenu(drinks);
        }

        private void ReturnMainMenu(List<IDrink> drinks)
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "R":
                case "r":
                    UserInterface.MainMenu();
                    UserInterface.Choices();
                    SodaMachineSwitch(drinks);
                    break;
            }
        }

        public void SodaMachineSwitch(List<IDrink> drinks)
        {

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "I":
                case "i":
                    InfoAboutProducts(drinks);
                    break;

                case "B":
                case "b":
                    BuySodaList(drinks);
                    break;

                case "W":
                case "w":
                    //CheckWallet();
                    break;
                default:
                    break;
            }
        }

        public void Start()
        {
            UserInterface.MainMenu();
            UserInterface.Choices();
            SodaMachineSwitch(Storage.drinks);
        }
    }
}
