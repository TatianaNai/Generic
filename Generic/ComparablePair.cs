using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class ComparablePair <T, U>  : IComparable<ComparablePair<T,U>>
                                        where T : IComparable<T>
                                        where U : IComparable<U>
    {
        public T ParametrT { get; }
        public U ParametrU { get; }

        public ComparablePair(T parametrT, U parametrU)
        {
            ParametrT = parametrT;
            ParametrU = parametrU;
        }

        public int CompareTo(ComparablePair<T, U>? other)
        {
            int resultOfComparisonFirstItems = ParametrT.CompareTo(other.ParametrT);
            int resultOfComparisonSecondItems = ParametrU.CompareTo(other.ParametrU);

            return resultOfComparisonFirstItems == 0 ? resultOfComparisonSecondItems : resultOfComparisonFirstItems;
        }
    }
}
