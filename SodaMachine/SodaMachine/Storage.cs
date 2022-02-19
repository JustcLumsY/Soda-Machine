using System;
using System.Collections.Generic;
using System.Linq;
using SodaMachine.Enums;
using SodaMachine.Implementations;
using SodaMachine.Interfaces;

namespace SodaMachine
{
    internal class Storage
    {
        public List<IDrink> drinks { get; set; }

        public Storage()
        {
            drinks = new List<IDrink>();
           
        }

        public void InitializeDrinks()
        {
            drinks.Add(new CocaCola(22, 10));
            drinks.Add(new Pepsi(18, 5));
            drinks.Add(new Urge(25, 11));
        }

        public IDrink GetDrink(DrinkTypeEnum type)
        {
            IDrink drink = drinks.FirstOrDefault(i => i.Type == type);
            if (drink != null)
            {
                if (drink.Amount > 0)
                {
                    drink.Amount--;

                }
            }

            return drink;
        }

        public bool CheckStorage(DrinkTypeEnum type)
        {
            IDrink drink = drinks.FirstOrDefault(x => x.Type == type);
            if (drink != null) //Spørr Stian om denne.
            {
                return drink.Amount > 0;
            }

            return false;
        }

        public IDrink GetDrinkInfo(DrinkTypeEnum type)
        {
            IDrink drink = drinks.FirstOrDefault(x => x.Type == type);

            return drink;
        }

    }
}
