using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    class CaffeLatte : Drink
    {
        public CaffeLatte() : base(DrinkNames.CaffeLatte, DrinkType.CoffeineDrink, DrinkSize.Tall, true)
        {
        }
    }
}
