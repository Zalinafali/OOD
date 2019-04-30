using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_2
{
    public abstract class Carnivore
    {
        public abstract string GetCarnivoreRace();
        public void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetCarnivoreRace() + " eats " + h.GetHerbivoreRace());
        }
    }

    public class Lion : Carnivore
    {
        public override string GetCarnivoreRace()
        {
            return ("Lion");
        }
    }

    public class Puma : Carnivore
    {
        public override string GetCarnivoreRace()
        {
            return ("Puma");
        }
    }

    public class Leopard : Carnivore
    {
        public override string GetCarnivoreRace()
        {
            return ("Leopard");
        }
    }
}
