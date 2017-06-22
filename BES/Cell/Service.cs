using System.Collections.Generic;

namespace BES.Cell
{
    internal static class Service
    {
        public static ICollection<Cell.Interface> NewCollection() => new HashSet<Cell.Interface>();
    }
}
