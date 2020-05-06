using System;

namespace Starbucks
{
    class Program
    {
        static void Main(string[] args)
        {
            IScreen gui = new UserInterface();
            Menu menu = new Menu(gui);
            menu.Start();
        }
    }
}

