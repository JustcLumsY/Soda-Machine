using SodaMachine.Enums;
using SodaMachine.Interfaces;

namespace SodaMachine.Implementations
{
    internal class Urge : IDrink
    {
        public int Price { get; }
        public int Amount { get; set; }
        public DrinkTypeEnum Type { get; }

        public Urge(int price, int amount)
        {
            Price = price;
            Amount = amount;
            Type = DrinkTypeEnum.Urge;
        }
    }
}
