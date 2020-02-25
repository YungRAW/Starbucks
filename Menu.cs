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

        public Menu(IScreen gui)
        {
            this.gui = gui;
            this.currentState = MenuStates.Initialized;
            this.menuPrinter = new MenuPrinter(gui);
            this.menuValidator = new MenuValidator();
            this.isStarted = false;
            this.coffeeRobot = new CoffeeRobot();
        }

        public void Start()
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
                        currentState = menuValidator.ValidateStateTransition(userInput, currentState);
                        break;

                    case MenuStates.OrderingDrink:
                        gui.ClearScreen();
                        menuPrinter.SecondScreen();
                        userInput = gui.ReadInputInteger();  
                        drink = coffeeRobot.MakeDrink(userInput);
                        currentState = menuValidator.ValidateStateTransition(userInput, currentState, drink);
                        break;

                    case MenuStates.SelectDrinkSize:
                        gui.ClearScreen();
                        menuPrinter.ThirdScreen();
                        userInput = gui.ReadInputInteger();
                        currentState = menuValidator.ValidateStateTransition(userInput, currentState, drink);
                        drink.SetDrinkSize(userInput.ToDrinkSize());
                        break;

                    case MenuStates.SelectCoffeeType:
                        gui.ClearScreen();
                        menuPrinter.FourthScreen();
                        userInput = gui.ReadInputInteger();
                        currentState = menuValidator.ValidateStateTransition(userInput, currentState, drink);
                        (drink as ICoffeineDrink).SetCoffeeType(userInput.ToCoffeeType());
                        break;

                    case MenuStates.Finished:
                        gui.ClearScreen();
                        menuPrinter.FifthScreen();
                        userInput = gui.ReadInputInteger();
                        currentState = menuValidator.ValidateStateTransition(userInput, currentState);
                        break;

                    case MenuStates.Exit:
                        isStarted = false;
                        break;
                }
            }
        }
    }
}
