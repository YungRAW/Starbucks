using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public interface ICoffeineDrink : IDrink
    {
        void SetCoffeeType(CoffeeType coffeeType);

    }
}
