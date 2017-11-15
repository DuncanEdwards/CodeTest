using System.Collections.Generic;

namespace IDL.Question1and2.Sorter
{

    public class Sorter
    {
        public IList<T> BubbleSort<T>(IList<T> list, IComparer<T> comparer)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;
                for (int j = 1; j < list.Count; j++)
                {
                    T x = list[j];
                    T y = list[j - 1];
                    if (comparer.Compare(x, y) > 0)
                    {
                        list[j] = y;
                        list[j - 1] = x;
                        isSorted = false;
                    }
                }
            }

            return list;
        }
    }

}
