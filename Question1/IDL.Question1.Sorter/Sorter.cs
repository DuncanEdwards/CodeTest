using System.Collections.Generic;

namespace IDL.Question1.Sorter
{

    public class Sorter
    {
        public IList<T> BubbleSort<T>(IList<T> list, IComparer<T> comparer)
        {
            bool incomplete = false;

            for (int i = 0; i <= list.Count; i++)
            {
                while (!incomplete)
                {
                    incomplete = true;
                    for (int j = 1; j < list.Count; j++)
                    {
                        T x = list[j];
                        T y = list[j - 1];
                        if (comparer.Compare(x, y) > 0)
                        {
                            list[j] = y;
                            list[j - 1] = x;
                            incomplete = false;
                        }
                    }
                }
            }

            return list;
        }
    }

}
