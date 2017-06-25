namespace BES.TruthTable
{
    using System.Collections.Generic;

    public class Model
    {
        public Model()
        {
            Cells = new HashSet<Cells.Interface>();
        }
        public ICollection<Cells.Interface> Cells { get; set; }
    }
}
