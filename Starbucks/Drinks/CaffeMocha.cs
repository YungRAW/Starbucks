using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks.CoffeeDrinks
{
    class CaffeMocha : Drink
    {
        public CaffeMocha() : base(DrinkNames.CaffeMocha, DrinkType.CoffeineDrink, DrinkSize.Tall, true)
        {

        }
    }
}
