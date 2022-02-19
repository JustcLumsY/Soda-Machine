﻿using System;

namespace SodaMachine
{
    internal class MoneyHandler
    {
       public int AmountOfMoney;
        public MoneyHandler(){}

        public bool HasEnoughMoney(int price)
        {
            if (AmountOfMoney >= price)
            {
                return true;
            }
            return false;
        }

        public int SpendMoney(int price)
        {
            AmountOfMoney -= price;
            return AmountOfMoney;
        }
        
        public void InsertCoin()
        {
            var userInput = Convert.ToInt32(Console.ReadLine());
            AmountOfMoney += userInput;
        }
    }
}
