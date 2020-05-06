using Starbucks.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public class Menu
    {
        private IScreen gui;
        private MenuStates currentState;
        private MenuPrinter menuPrinter;
        private MenuValidator menuValidator;
        private bool isStarted;
        private CoffeeRobot coffeeRobot;
        private IDrink drink;
        private ILogger myLogger;

        public Menu(IScreen gui)
        {
            this.gui = gui;
            this.currentState = MenuStates.Initialized;
            this.menuPrinter = new MenuPrinter(gui);
            this.menuValidator = new MenuValidator();
            this.isStarted = false;
            this.coffeeRobot = new CoffeeRobot();
            this.myLogger = new ConsoleLogger();
        }

  

        public void Start()
        {
            try
            {
                isStarted = true;
                while (isStarted)
                {
                    int userInput;
                    switch (currentState)
                    {
                        case MenuStates.Initialized:
                            gui.ClearScreen();
                            menuPrinter.FirstScreen();
                            userInput = gui.ReadInputInteger();
                            currentState = menuValidator.ValidateStateTransition(userInput, currentState, myLogger);
                            break;

                        case MenuStates.OrderingDrink: 
                            gui.ClearScreen();
                            menuPrinter.SecondScreen();
                            userInput = gui.ReadInputInteger();
                            drink = coffeeRobot.MakeDrink(userInput);
                            currentState = menuValidator.ValidateStateTransition(userInput, currentState, myLogger, drink);                          
                            break;

                        case MenuStates.SelectDrinkSize:
                            gui.ClearScreen();
                            menuPrinter.ThirdScreen();
                            userInput = gui.ReadInputInteger();
                            currentState = menuValidator.ValidateStateTransition(userInput, currentState, myLogger, drink);
                            drink.SetDrinkSize(userInput.ToDrinkSize());
                            break;

                        case MenuStates.SelectCoffeeType:
                            gui.ClearScreen();
                            menuPrinter.FourthScreen();
                            userInput = gui.ReadInputInteger();
                            currentState = menuValidator.ValidateStateTransition(userInput, currentState, myLogger, drink);
                            (drink as ICoffeineDrink).SetCoffeeType(userInput.ToCoffeeType());
                            break;

                        case MenuStates.Finished:
                            gui.ClearScreen();
                            menuPrinter.FifthScreen();
                            gui.PrintMessageOnLine($"You ordered : {drink.GetDetails()}");
                            myLogger.Info("User ordered: " + drink.GetDetails());
                            userInput = gui.ReadInputInteger();
                            currentState = menuValidator.ValidateStateTransition(userInput, currentState, myLogger);
                            break;

                        case MenuStates.Exit:
                            isStarted = false;
                            break;
                    }
                }
            }
            catch(MyCustomException e)
            {
                myLogger.Fatal("Could not resolve menu!");
            }
        }
    }
}
