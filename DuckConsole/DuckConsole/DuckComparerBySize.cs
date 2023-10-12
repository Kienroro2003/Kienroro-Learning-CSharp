using System.Collections;

namespace DuckConsole;

public class DuckComparerBySize:IComparer<Duck>
{
    public SortCriteria SortBy = SortCriteria.SizeThenKind;
    public int Compare(Duck? x, Duck? y)
    {
        if (x.Size < y.Size)
            return -1;
        if (x.Size > y.Size)
            return 1;
        return 0;
    }
}