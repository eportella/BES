using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BES.Test
{
    [TestClass]
    public class CellsTest
    {
        [TestMethod]
        public void MAKE_SURE_THERE_CAN_NOT_BE_MORE_THAN_ONE_OUTPUT_COLUMN_WITH_A_RESULT()
        {
            var cells = new Cells.Model();
            var output = new Output.Model(new Alias.Name.Struct("S"));

            cells.Add(output);
            try
            {
                cells.Add(output);
                throw new System.InvalidOperationException();
            }
            catch (Output.Mutiple.Exception)
            {
            }
        }
    }
}
