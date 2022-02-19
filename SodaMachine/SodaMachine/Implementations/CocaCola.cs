using SodaMachine.Enums;
using SodaMachine.Interfaces;

namespace SodaMachine.Implementations
{
    public class CocaCola : IDrink
    {
        public int Price { get; }
        public int Amount { get; set; }
        public DrinkTypeEnum Type { get; }

        public CocaCola(int price, int amount)
        {
            Price = price;
            Amount = amount;
            Type = DrinkTypeEnum.CocaCola;
        }
    }
    
}