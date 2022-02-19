using SodaMachine.Enums;

namespace SodaMachine.Interfaces
{
    public interface IDrink
    {
        int Price { get; }
        int Amount { get; set; }
        DrinkTypeEnum Type { get; }
    }
}