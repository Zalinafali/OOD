using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Centaur : IToy
    {
        public string name;
        public int age;
        public bool isBeard;

        public Centaur(string name, int age, bool isBeard)
        {
            this.name = name;
            this.age = age;
            this.isBeard = isBeard;
        }

        public float Cost()
        {
            return 250f;
        }

        public string Summary()
        {
            if (isBeard)
            {
                return "I'm centaur. My name is " + name + " and I'm " + age + " with beard. " + " I'm " + Height() + " cm tall.";
            }
            else
                return "I'm centaur. My name is " + name + " and I'm " + age + ". I'm " + Height() + " cm tall.";
        }

        public float Height()
        {
            return 210f;
        }
    };
}
