using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public class MenuPrinter
    {
        public IScreen gui;

        public MenuPrinter(IScreen screen)
        {
            this.gui = screen;
        }

        public void FirstScreen()
        {

            gui.PrintMessageOnLine("1. Order a drink");
            gui.PrintMessageOnLine("2. Cancel");

            
        }

        public void SecondScreen()
        {
            gui.PrintMessageOnLine("What drink do you want?");
            gui.PrintMessageOnLine($"1. {DrinkNames.CaramelMacchiato}");
            gui.PrintMessageOnLine($"2. {DrinkNames.CaffeLatte}");
            gui.PrintMessageOnLine($"3. {DrinkNames.Cappuccino}");
            gui.PrintMessageOnLine($"4. {DrinkNames.CaffeAmericano}");
            gui.PrintMessageOnLine($"5. {DrinkNames.WhiteChocolateMocha}");
            gui.PrintMessageOnLine($"6. {DrinkNames.CaffeMocha}");
            gui.PrintMessageOnLine($"7. {DrinkNames.ChaiTeaLatte}");
            gui.PrintMessageOnLine($"8. {DrinkNames.PumpkinSpiceLatte}");
            gui.PrintMessageOnLine($"9. {DrinkNames.DoppioEspressoMacchiato}");
            gui.PrintMessageOnLine($"10. {DrinkNames.EspressoShot}");

        }
        public void ThirdScreen()
        {
            gui.PrintMessageOnLine("What size do you want your drink?");
            gui.PrintMessageOnLine("1. Short");
            gui.PrintMessageOnLine("2. Tall");
            gui.PrintMessageOnLine("3. Grande");
            gui.PrintMessageOnLine("4. Venti");

        }
        public void FourthScreen()
        {
            gui.PrintMessageOnLine("Do you want stronger coffee or a more flavored one?");
            gui.PrintMessageOnLine("1. Strong coffee");
            gui.PrintMessageOnLine("2. Flavored coffee");

        }

        public void FifthScreen()
        {
            gui.PrintMessageOnLine("Thank you for ordering! Here is your drink!");
            gui.PrintMessageOnLine("Please enjoy and come again!");

            gui.PrintMessageOnLine("1.Return to main menu");
            gui.PrintMessageOnLine("2.Exit");

        }


    }
}
