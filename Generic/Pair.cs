using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Pair <S, T>
    {
        public S Item1 { get; }
        public T Item2 { get; }

        public Pair(S item1, T item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}
