using SodaMachine.Enums;
using SodaMachine.Interfaces;

namespace SodaMachine.Implementations
{
    internal class Pepsi : IDrink
    {
        public int Price { get; }
        public int Amount { get; set; }
        public DrinkTypeEnum Type { get; }


        public Pepsi(int price, int amount)
        {
            Price = price;
            Amount = amount;
            Type = DrinkTypeEnum.Pepsi;
        }
    }
}
