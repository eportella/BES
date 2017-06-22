using System.Collections.Generic;

namespace BES.TruthTable
{
    internal class Model
    {
        public Model()
        {
            Cells = new HashSet<ICollection<Cell.Interface>>();
        }
        public ICollection<ICollection<Cell.Interface>> Cells { get; set; }
    }
}
