using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks.Drinks
{
    class EspressoShot : Drink
    {
        public EspressoShot() : base(DrinkNames.EspressoShot, DrinkType.CoffeineDrink, DrinkSize.Short, true)
        {

        }
    }
}
