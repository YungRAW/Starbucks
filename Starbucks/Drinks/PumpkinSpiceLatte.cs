using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks.Drinks
{
    class PumpkinSpiceLatte : Drink
    {
        public PumpkinSpiceLatte() : base(DrinkNames.PumpkinSpiceLatte, DrinkType.CoffeineDrink, DrinkSize.Grande, true)
        {

        }
    }
}
