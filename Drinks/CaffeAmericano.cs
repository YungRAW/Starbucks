using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks.CoffeeDrinks
{
    class CaffeAmericano : Drink
    {
        public CaffeAmericano() : base(DrinkNames.CaffeAmericano, DrinkType.CoffeineDrink, DrinkSize.Venti, true)
        {

        }
    }
}
