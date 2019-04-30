using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_2
{
    public abstract class Herbivore
    {
        public abstract string GetHerbivoreRace();

        public void Eat(Plant p)
        {
            Console.WriteLine(this.GetHerbivoreRace() + " eats " + p.GetPlantType());
        }
    }

    public class Gazelle : Herbivore
    {
        public override string GetHerbivoreRace()
        {
            return ("Gazelle");
        }
    }

    public class Llama : Herbivore
    {
        public override string GetHerbivoreRace()
        {
            return ("Llama");
        }
    }

    public class GiantPanda : Herbivore
    {
        public override string GetHerbivoreRace()
        {
            return ("Giant Panda");
        }
    }
}
