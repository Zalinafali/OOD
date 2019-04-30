using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFrames
{
    public class Iterator
    {
        public interface IIterable
        {
            IIterator GetIterator();
        }

        public interface IIterator
        {
            Record Current();

            bool Next();
        }
    }
}
