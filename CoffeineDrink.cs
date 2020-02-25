using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    class CoffeineDrink : Drink
    {
        private string Name { get; set; }
        private string Size { get; set; }
        private string CoffeeType { get; set; }



        public CoffeineDrink() : base()
        {
            this.Name = Name;

        }

        public CoffeineDrink(string Name) : base(Name)
        {
            this.Name = Name;

        }

        public override void ChooseSize(string size)
        {
            this.Size = size;
        }

        public void ChooseType(string type)
        {
            this.CoffeeType = type;
        }


    }
}
