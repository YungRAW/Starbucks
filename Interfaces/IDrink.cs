using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public interface IDrink
    {
        string GetDetails();
        bool HasStandardSize();
        void SetDrinkSize(DrinkSize drinkSize);
        bool HasCoffeine();
        bool IsShort();
    }
}
