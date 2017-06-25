namespace BES.Cells
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class Model : Interface
    {
        ICollection<Cell.Interface> Cells { get; set; }

        public Model()
        {
            Cells = new HashSet<Cell.Interface>();
        }

        public int Count => Cells.Count;

        public bool IsReadOnly => Cells.IsReadOnly;

        public void Add(Cell.Interface cell)
        {
            if (Cells.Any(x => x is Output.Interface))
                throw new Output.Mutiple.Exception();

            Cells.Add(cell);
        }

        public void Clear()
        {
            Cells.Clear();
        }

        public bool Contains(Cell.Interface cell)
        {
            return Cells.Contains(cell);
        }

        public void CopyTo(Cell.Interface[] array, int arrayIndex)
        {
            Cells.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Cell.Interface> GetEnumerator()
        {
            return Cells.GetEnumerator();
        }

        public bool Remove(Cell.Interface cell)
        {
            return Cells.Remove(cell);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cells.GetEnumerator();
        }
    }
}