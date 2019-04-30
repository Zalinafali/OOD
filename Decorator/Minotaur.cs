using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Minotaur : IToy
    {
        public string name;
        public int age;
        public int mass;

        public Minotaur(string name, int age, int mass)
        {
            this.name = name;
            this.age = age;
            this.mass = mass;
        }

        public float Cost()
        {
            return 250f;
        }

        public string Summary()
        {
                return "I'm minotaur. My name is " + name + " and I'm " + age + ". I'm " + Height() + " cm tall with mass" + mass;
        }

        public float Height()
        {
            return 250f;
        }
    }
}
