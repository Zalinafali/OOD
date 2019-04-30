using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFrames
{
    public class Record
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Record()
        { }
        public Record(string name, string surname, string gender, int age)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
        }

    }

    public abstract class DataFrame : Iterator.IIterable
    {
        public abstract Iterator.IIterator GetIterator();
    }

    public class ListDataFrame : DataFrame, Iterator.IIterable
    {
        List<Record> list;

        public ListDataFrame(List<Record> list)
        {
            this.list = new List<Record>(list);
        }

        public override Iterator.IIterator GetIterator()
        {
            return new ListDataFrameIterator(this);
        }

        private class ListDataFrameIterator : Iterator.IIterator
        {
            int index;
            ListDataFrame list;
            public ListDataFrameIterator(ListDataFrame ldf)
            {
                index = 0;
                this.list = ldf;
            }
            public Record Current()
            {
                if (index < list.list.Count())
                {
                    return list.list.ElementAt(index++);
                }
                else
                    return null;
            }

            public bool Next()
            {
                if (index < list.list.Count())
                    return true;
                else
                    return false;
            }
        }
    }

    public class FileDataFrame : DataFrame, Iterator.IIterable
    {
        string filename;

        public FileDataFrame(string filename)
        {
            this.filename = filename;
        }

        public override Iterator.IIterator GetIterator()
        {
            return new FileDataFrameIterator(this);
        }

        private class FileDataFrameIterator : Iterator.IIterator
        {
            string data;
            StreamReader file;

            public FileDataFrameIterator(FileDataFrame fdf)
            {
                string CombinedPath = Path.Combine(Directory.GetCurrentDirectory(),  "../../" + fdf.filename);
                this.file = new StreamReader(Path.GetFullPath(CombinedPath));
            }

            public Record Current()
            {
                if ((data = file.ReadLine()) == null)
                {
                    Console.WriteLine("error current");
                    return null;
                }
                string[] features = new string[4];
                features = data.Split(',');
                return new Record(features[0], features[1], features[2], Convert.ToInt32(features[3]));
            }

            public bool Next()
            {
                return !file.EndOfStream;
            }
        }
    }
}
