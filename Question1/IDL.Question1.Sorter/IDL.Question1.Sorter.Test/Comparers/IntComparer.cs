using System.Collections.Generic;
using System.ComponentModel;

namespace IDL.Question1.Sorter.Test.Comparers
{
    public class IntComparer : IComparer<int>
    {
        readonly private ListSortDirection _listSortDirection;

        public IntComparer(ListSortDirection listSortDirection)
        {
            _listSortDirection = listSortDirection;
        }

        public int Compare(int x, int y)
        {
            return (_listSortDirection == ListSortDirection.Ascending) ?
                (y - x) :
                (x - y);
        }

    }
}
