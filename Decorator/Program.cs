using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IToy doll = new Doll();
            IToy warrior = new Warrior();
            IToy raceDriver = new RaceDriver();

            // Everythong works properly, jsut main should look better but I was out of time
            IToy minotaur = new Centaur("John", 9, true);

            AddSword sword = new AddSword(minotaur);
            AddJumping dress = new AddJumping(sword);
            Console.WriteLine(dress.Cost());
            Console.WriteLine(dress.Summary());
            Console.WriteLine(dress.Height());

            Console.WriteLine(dress.Summary());
            Console.WriteLine(dress.Summary());
            Console.WriteLine(dress.Summary());
            Console.WriteLine(dress.Summary());
            Console.WriteLine(dress.Summary());

            AddDancing dancingToy = new AddDancing(dress, "gangnam style");
            Console.WriteLine(dancingToy.Summary());
            AddDancing dancing2Toy = new AddDancing(dancingToy, "solo capoeira");
            Console.WriteLine(dancing2Toy.Summary());

            AddStory storyToy = new AddStory(dancing2Toy, "jokes");
            Console.WriteLine(storyToy.Summary());
        }
    }
}
