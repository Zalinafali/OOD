using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Decorator : IToy
    {
        protected IToy toy;

        public Decorator(IToy toy)
        {
            this.toy = toy;
        }

        public virtual float Cost()
        {
            return this.toy.Cost();
        }

        public float Height()
        {
            return this.toy.Height();
        }

        public virtual string Summary()
        {
            return this.toy.Summary();
        }
    }

    class AddSword : Decorator
    {
        public AddSword(IToy toy) : base(toy) { }

        public override float Cost()
        {
            return this.toy.Cost() + 15;
        }

        public override string Summary()
        {
            return this.toy.Summary() + " I have a sword!";
        }
    }

    class AddHelmet : Decorator
    {
        public AddHelmet(IToy toy) : base(toy) { }

        public override float Cost()
        {
            return this.toy.Cost() + 10;
        }

        public override string Summary()
        {
            return this.toy.Summary() + " I have a helmet on my head!";
        }
    }

    class AddDress : Decorator
    {
        private string pattern;

        public AddDress(IToy toy, string pattern) : base(toy) {
            this.pattern = pattern;
        }

        public override float Cost()
        {
            if ("flower" == pattern)
                return this.toy.Cost() + 20;
            else if ("dotted" == pattern)
                return this.toy.Cost() + (float)(19.99);
            else
                return this.toy.Cost();
        }

        public override string Summary()
        {
            if ("flower" == pattern)
                return this.toy.Summary() + " I have a flower dress!";
            else if ("dotted" == pattern)
                return this.toy.Summary() + " I have a dotted dress!";
            else
                return this.toy.Summary();
        }
    }

    class AddJumping : Decorator
    {
        private int jumps = 0;
        public AddJumping(IToy toy) : base(toy) { }

        public override float Cost()
        {
            return this.toy.Cost() + 20;
        }

        public override string Summary()
        {
            if (jumps < 5)
            {
                float heightOfJump = (float)(0.5) * this.toy.Height() - jumps * (float)(0.1) * this.toy.Height();
                jumps++;
                return this.toy.Summary() + " I can jump! I just jumped " + heightOfJump + " cm!";
            }
            else
                return this.toy.Summary();
        }
    }

    //class AddDancing : Decorator
    //{
    //    public List<string> dances = new List<string>();
    //    public AddDancing(IToy toy, string dance) : base(toy)
    //    {
    //        this.dances.Add(dance);
    //        if (toy is AddDancing)
    //        {
    //            foreach (string s in (toy as AddDancing).dances)
    //            {
    //                this.dances.Add(s);
    //            }
    //        }
    //    }

    //    public override float Cost()
    //    {
    //        float additionalCost = 0;
    //        List<string> knownDances = new List<string>();
    //        foreach (string s in dances)
    //        {
    //            if ("breakdance" == s && !knownDances.Contains("breakdance"))
    //            {
    //                additionalCost += 50;
    //                knownDances.Add("breakdance");
    //            }
    //            else if ("solo capoeira" == s && !knownDances.Contains("solo capoeira"))
    //            {
    //                additionalCost += 70;
    //                knownDances.Add("solo capoeira");
    //            }
    //            else if ("gangnam style" == s && !knownDances.Contains("breakdance"))
    //            {
    //                additionalCost += 100;
    //                knownDances.Add("gangnam style");
    //            }
    //        }
    //        return this.toy.Cost() + additionalCost;
    //    }

    //    public override string Summary()
    //    {
    //        string dancesDescription = "";
    //        List<string> knownDances = new List<string>();
    //        foreach (string s in dances)
    //        {
    //            if ("breakdance" == s && !knownDances.Contains("breakdance"))
    //            {
    //                dancesDescription += " I can dance breakdance.";
    //                knownDances.Add("breakdance");
    //            }
    //            else if ("solo capoeira" == s && !knownDances.Contains("solo capoeira"))
    //            {
    //                dancesDescription += " I can dance solo capoeira.";
    //                knownDances.Add("solo capoeira");
    //            }
    //            else if ("gangnam style" == s && !knownDances.Contains("breakdance"))
    //            {
    //                dancesDescription += " I can dance gangnam style.";
    //                knownDances.Add("gangnam style");
    //            }
    //        }
    //        return this.toy.Summary() + dancesDescription;
    //    }

    class AddDancing : Decorator
    {
        string dance;
        public AddDancing(IToy toy, string dance) : base(toy)
        {
            this.dance = dance;
        }

        public override float Cost()
        {
                if ("breakdance" == dance)
                {
                return this.toy.Cost() + 50;
            }
                else if ("solo capoeira" == dance)
                {
                return this.toy.Cost() + 70;
            }
                else if ("gangnam style" == dance)
                {
                return this.toy.Cost() + 100;
            }
            return this.toy.Cost();
        }

        public override string Summary()
        {
            if ("breakdance" == dance)
            {
                return this.toy.Summary() + " I can dance " + dance + "!";
            }
            else if ("solo capoeira" == dance)
            {
                return this.toy.Summary() + " I can dance " + dance + "!";
            }
            else if ("gangnam style" == dance)
            {
                return this.toy.Summary() + " I can dance " + dance + "!";
            }
            return this.toy.Summary();
        }

    }

    class AddStory : Decorator
    {
        private string story;
        public AddStory(IToy toy, string story) : base(toy) { this.story = story; }

        public override float Cost()
        {
            if ("scary story" == story || "jokes" == story)
                return this.toy.Cost() + 30;
            else
                return this.toy.Cost();
        }

        public override string Summary()
        {
            if ("scary story" == story)
                return this.toy.Summary() + " I can tell scary stories! ";
            else if ("jokes" == story)
                return this.toy.Summary() + " I can tell jokes! ";
            else
                return this.toy.Summary();
        }
    }
}