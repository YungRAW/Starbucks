using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks.Drinks
{
    class ChaiTeaLatte : Drink
    {
        public ChaiTeaLatte() : base(DrinkNames.ChaiTeaLatte, DrinkType.NonCoffeineDrink, DrinkSize.Grande , true)
        {

        }
    }
}
