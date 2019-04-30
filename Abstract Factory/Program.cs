using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToDo: implementation
            var african = new African();
            var southAmerican = new SouthAmerican();
            var asian = new Asian();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Exit")
                    break;

                if (input == "African")
                {
                    african.FoodChain();
                }

                if (input == "American")
                {
                    southAmerican.FoodChain();
                }

                if (input == "Asian")
                {
                    asian.FoodChain();
                }

                if (input == "Mixed1")
                {
                    FoodChain(african.Plant(), southAmerican.Herbivore(), asian.Carnivore());
                }
                
                if (input == "Mixed2")
                {
                    FoodChain(asian.Plant(), african.Herbivore(), asian.Carnivore());
                }
                
                if (input == "Mixed3")
                {
                    FoodChain(asian.Plant(), southAmerican.Herbivore(), african.Carnivore());
                }
            }
        }

        public static void FoodChain(Plant plant, Herbivore herbivore, Carnivore carnivore)
        {
            Console.WriteLine("Food Chain:");
            herbivore.Eat(plant);
            carnivore.Eat(herbivore);
        }
    }
}
