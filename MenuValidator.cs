using Starbucks.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public class MenuValidator
    {
        public MenuStates ValidateStateTransition(int userInput, MenuStates currentState, IDrink drink = null)
        {
            switch (currentState)
            {
                case MenuStates.Initialized:
                    if (userInput == 1)
                    {
                        return MenuStates.OrderingDrink;
                    }
                    else
                    {
                        return MenuStates.Exit;
                    }

                case MenuStates.OrderingDrink:
                    if (userInput >= 1 && userInput <= 10)
                    {
                        if (drink.HasStandardSize() && !drink.HasCoffeine()) // logic for espresso shot and non coffeine drinks
                        {
                            return MenuStates.Finished;
                        }

                        if (drink.HasStandardSize() && drink.HasCoffeine())
                        {
                            return MenuStates.SelectCoffeeType;
                        }

                        if (!drink.HasStandardSize())
                        {
                            return MenuStates.SelectDrinkSize;
                        }
                    }
                    return MenuStates.OrderingDrink;


                case MenuStates.SelectDrinkSize:
                    if (userInput >= 1 && userInput <= 4)
                    {
                        if (drink.HasCoffeine())
                        {
                            return MenuStates.SelectCoffeeType;
                        }
                        else
                        {
                            return MenuStates.Finished;
                        }
                    }
                    return MenuStates.SelectDrinkSize;


                case MenuStates.SelectCoffeeType:
                    if (userInput >= 1 && userInput <= 2)
                    {
                        return MenuStates.Finished;
                    }
                    return MenuStates.SelectDrinkSize;


                case MenuStates.Finished:

                    if (userInput == 1)
                    {
                        return MenuStates.Initialized;
                    }
                    else
                    {
                        return MenuStates.Exit;
                    }

                default:
                    return MenuStates.Exit;

            }
        }
    }
}

