using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace IDL.Question1.Sorter.Test.Comparers
{
    public class StringComparer : IComparer<string>
    {
        readonly private ListSortDirection _listSortDirection;

        public StringComparer(ListSortDirection listSortDirection)
        {
            _listSortDirection = listSortDirection;
        }

        public int Compare(string x, string y)
        {
            return (_listSortDirection == ListSortDirection.Ascending) ?
                String.Compare(y, x) :
                String.Compare(x, y);
        }

    }
}
