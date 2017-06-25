using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BES.Test
{
    [TestClass]
    public class TruthTableTest
    {
        [TestMethod]
        public void ENSURE_THAT_THE_COLLECTION_WILL_BE_A_HASHSET()
        {
            Assert.IsTrue(new TruthTable.Model().Cells is HashSet<Cells.Interface>);
        }
    }
}
