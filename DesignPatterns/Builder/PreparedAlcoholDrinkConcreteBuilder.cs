using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class PreparedAlcoholDrinkConcreteBuilder : IBuilder
    {
        private PreparedDrink _preparedDrink;
        public PreparedAlcoholDrinkConcreteBuilder()
        {
            Reset();
        }
        public void AddIngredients(string ingredient)
        {
            if (_preparedDrink.Ingredients == null)
                _preparedDrink.Ingredients = new List<string>();

            _preparedDrink.Ingredients.Add(ingredient);
        }

        public void Mix()
        {
            Console.WriteLine("Mezclamos los ingredientes");
        }

        public void Reset()
        {
            _preparedDrink = new PreparedDrink();
        }
        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Listo para beberse");
        }

        public void SetAlcohol(decimal alcohol)
        {
            _preparedDrink.Alcohol = alcohol;
        }

        public void SetMilk(int milk)
        {
            _preparedDrink.Milk = milk;
        }

        public void SetWater(int water)
        {
            _preparedDrink.Water = water;
        }
        public PreparedDrink GetPreparedDrink () => _preparedDrink;
    }
}
