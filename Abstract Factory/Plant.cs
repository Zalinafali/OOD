using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A_2
{
    public abstract class Plant
    {
        public abstract string GetPlantType();
    }

    public class Grass : Plant
    {
        public override string GetPlantType()
        {
            return ("Grass");
        }
    }

    public class Cattails : Plant
    {
        public override string GetPlantType()
        {
            return ("Cattails");
        }
    }

    public class Bamboo : Plant
    {
        public override string GetPlantType()
        {
            return ("Bamboo");
        }
    }
}
