using Starbucks.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public class MenuValidator
    {
        public MenuStates ValidateStateTransition(int userInput, MenuStates currentState, ILogger logger, IDrink drink = null)
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
                            logger.Info("User ordered drink");
                            return MenuStates.Finished;
                        }

                        if (drink.HasStandardSize() && drink.HasCoffeine())
                        {
                            logger.Info("User ordered drink");
                            return MenuStates.SelectCoffeeType;
                        }

                        if (!drink.HasStandardSize())
                        {
                            logger.Info("User ordered drink"); ;
                            return MenuStates.SelectDrinkSize;
                        }
                    }
                    else
                    {
                        logger.Error("Couldnt order drink!");
                        throw new MyCustomException("Couldnt order drink!");
                        
                    }
                    return MenuStates.OrderingDrink;


                case MenuStates.SelectDrinkSize:
                    if (userInput >= 1 && userInput <= 4)
                    {
                        if (drink.HasCoffeine())
                        {
                            logger.Info("User selected drink size");
                            return MenuStates.SelectCoffeeType;
                        }
                        else
                        {
                            logger.Info("User selected drink size");
                            return MenuStates.Finished;
                        }
                    }
                    else
                    {
                        logger.Error("Couldnt select drink size!");
                        throw new MyCustomException("Couldnt select drink size!");
                    }


                case MenuStates.SelectCoffeeType:
                    if (userInput >= 1 && userInput <= 2)
                    {
                        logger.Info("User selected coffee type");
                        return MenuStates.Finished;
                    }
                    else
                    {
                        logger.Error("Couldnt select coffee type!");
                        throw new MyCustomException("Couldnt select coffee type!");
                    }


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

