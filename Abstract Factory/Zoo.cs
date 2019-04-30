using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_2
{
    public abstract class Zoo
    {
        public abstract Plant Plant();
        public abstract Herbivore Herbivore();
        public abstract Carnivore Carnivore();

        public void FoodChain()
        {
            Program.FoodChain(Plant(), Herbivore(), Carnivore());
        }
    }

    public class African : Zoo
    {
        public override Plant Plant()
        {
            return new Grass();
        }
        public override Herbivore Herbivore()
        {
            return new Gazelle();
        }
        public override Carnivore Carnivore()
        {
            return new Lion();
        }
    }

    public class SouthAmerican : Zoo
    {
        public override Plant Plant()
        {
            return new Cattails();
        }
        public override Herbivore Herbivore()
        {
            return new Llama();
        }
        public override Carnivore Carnivore()
        {
            return new Puma();
        }
    }
    public class Asian : Zoo
    {
        public override Plant Plant()
        {
            return new Bamboo();
        }
        public override Herbivore Herbivore()
        {
            return new GiantPanda();
        }
        public override Carnivore Carnivore()
        {
            return new Leopard();
        }
    }
}
