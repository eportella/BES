using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BES.Test
{
    [TestClass]
    public class AliasTest
    {
        [TestMethod]
        public void CREATE_VALUE_SUCCESS()
        {
            var alias = new Alias.Name.Struct("S");

            Assert.IsTrue(alias.Value == "S");
        }

        [TestMethod]
        public void CREATE_DEFAULT_VALUE_WITH_NAME_EMPTY()
        {
            var alias = new Alias.Name.Struct();

            Assert.IsTrue(alias.Value == "");
        }

        [TestMethod]
        public void COMPARE_EQUALITY_BETWEEN_TWO_VALUES()
        {
            var aliasLeft = new Alias.Name.Struct("S");

            var aliasRight = new Alias.Name.Struct("S");

            Assert.IsTrue(aliasLeft.Value == aliasRight.Value);
            Assert.IsTrue(aliasLeft == aliasRight);
        }

        [TestMethod]
        public void COMPARE_NON_EQUALITY_BETWEEN_TWO_VALUES()
        {
            var aliasLeft = new Alias.Name.Struct("S");

            var aliasRight = new Alias.Name.Struct("T");

            Assert.IsTrue(aliasLeft.Value != aliasRight.Value);
            Assert.IsTrue(aliasLeft != aliasRight);
        }



    }
}
