using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFrames
{
    class Program
    {
        static void PrintDataFrame(DataFrame df)
        {
            Iterator.IIterator it = df.GetIterator();
            do
            {
                Record cr = it.Current();
                if (cr == null) return;
                Console.WriteLine(cr.Name + " " + cr.Surname + " " + cr.Gender + " " + cr.Age);
            }
            while (it.Next());
        }

        static Tuple<string, double> Mode(DataFrame df)
        {
            int male = 0;
            int female = 0;
            Iterator.IIterator it = df.GetIterator();
            do
            {
                Record cr = it.Current();
                if (cr == null) return null;
                if (cr.Gender.Contains("M")) male++;
                else female++;
            }
            while (it.Next());

            string most = "";
            double ratio = 0;
            if (male > female)
            {
                most = "Male";
                ratio = (double)male * 100 / (female + male);
            }
            else
            {
                most = "Female";
                ratio = (double)female * 100 / (female + male);
            }

            return Tuple.Create(most, ratio);
        }



        //static //... ConcatenationWithCondition//...
        //{
        //    //...
        //}

        static void Main(string[] args)
        {
            List < Record > people = new List<Record>()
            {
                new Record("Keanu", "Reeves", "M", 25),
                new Record("Agent", "Smith", "M", 35),
                new Record("Carrie-Anne", "Moss", "F", 25),
                new Record("Gloria", "Foster", "M", 123),
                new Record("Belinda", "McClory", "F", 27)
            };
            ListDataFrame ldf = new ListDataFrame(people);
            PrintDataFrame(ldf);

            Tuple<string, double> res = Mode(ldf);
            Console.WriteLine($"mode = {res.Item1}, percent = {res.Item2}");

            FileDataFrame fdf = new FileDataFrame("dataFrame1.txt");
            PrintDataFrame(fdf);
            Tuple<string, double> res2 = Mode(fdf);
            Console.WriteLine($"mode = {res2.Item1}, percent = {res2.Item2}");
            //Console.WriteLine("\nConcatenation\n");
            //Func<Record, bool> f = r => r.Gender == "F";
            //PrintDataFrame(new ListDataFrame(ConcatenationWithCondition(ldf, fdf, f)));
            //FileDataFrame fdf2 = new FileDataFrame(ConcatenationWithCondition(ldf, fdf, f), "dataFrame2.txt");
        }
    }
}
