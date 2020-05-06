using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    class Drink : IDrink , ICoffeineDrink
    {

        protected string name { get; set; }
        protected DrinkSize size { get; set; }
        protected DrinkType type { get; set; }
        protected CoffeeType coffeeType { get; set; }
        protected bool hasStandardSize;


        public Drink(string name, DrinkType type) // constructor for normal Drinks
        {
            this.name = name;
            this.type = type;
           
        }

        public Drink(string name, DrinkType type , DrinkSize drinkSize, bool hasStandardSize) : this(name, type) // aici mostenim din base name si type si adaugam the rest
        {
            this.size = size;
            this.hasStandardSize = hasStandardSize;

        }

        public virtual string GetDetails() // pentru afisarea bauturii comandate
        {
            try
            {
                return $"{name}, {size} size.";
            }
            catch(MyCustomException e)
            {               
                throw new MyCustomException("Couldnt get details!");
            }

        }

        public virtual bool HasStandardSize() // verifica daca are masura standard
        {
            try
            {
                return hasStandardSize;
            }
            catch(MyCustomException exception)
            {
                throw new MyCustomException("Couldnt verify size!");
            }
            
        }

        public virtual void SetDrinkSize(DrinkSize drinkSize) // seteaza masura 
        {
            try
            {
                this.size = drinkSize;
            }
            catch(MyCustomException exception)
            {
                throw new MyCustomException("Couldnt set drink size!");
            }
            
        }

        public virtual bool HasCoffeine()
        {
            return type == DrinkType.CoffeineDrink;
        }

        public virtual bool IsShort()
        {
            return size == DrinkSize.Short;

        }

        public void SetCoffeeType(CoffeeType value)
        {
            try
            {
                coffeeType = value;
            }
            catch(MyCustomException exception)
            {
                throw new MyCustomException("Couldnt set coffee type!");
            }
            
        }


    }
}
