using System;
using System.Collections.Generic;

namespace Class_2._8
{
    public class HouseCatComparer : IComparer<HouseCat>
    {
        public int Compare(HouseCat a, HouseCat b)
        {
            // Compares two specified strings and returns an integer that indicates their relative position in the sort order
            return String.Compare(a.Name, b.Name);
        }
    }
}
