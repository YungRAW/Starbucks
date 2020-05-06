using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public static class ExtensionMethods
    {
        public static DrinkSize ToDrinkSize(this int input)
        {
            switch (input)
            {
                case 1:
                    return DrinkSize.Short;
                case 2:
                    return DrinkSize.Tall;
                case 3:
                    return DrinkSize.Grande;
                case 4:
                    return DrinkSize.Venti;
                default:
                    return DrinkSize.Short;
            }
        }

        public static CoffeeType ToCoffeeType(this int input)
        {
            switch (input)
            {
                case 1:
                    return CoffeeType.Strong;
                case 2:
                    return CoffeeType.Flavoured;
                default:
                    return CoffeeType.Strong;
            }
        }
    }
}

