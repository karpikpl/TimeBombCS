using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeBomb.Tests
{
    [TestClass]
    public class ParseArrayTests
    {
        [TestMethod]
        public void ParseArray_Should_ParseSampleData1()
        {
            // Arrange
            string[] data =
            {
                "***   * * * *** *** *** ***",
                "* *   * * *   *   *   * *  ",
                "* *   * *** *** *** *** ***",
                "* *   *   * *     * *   * *",
                "***   *   * *** *** *** ***"
            };
            const int expected = 142326;

            // Act
            var result = Solver.ParseArray(data);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseArray_Should_ParseSampleData2()
        {
            // Arrange
            string[] data =
            {
  "  *   * *** *** *** * *",
  "  *   *   *   * * * * *",
  "  *   * *** *** *** ***",
  "  *   * *   *   * *   *",
  "  *   * *** *** ***   *"
            };
            const int expected = 112284;

            // Act
            var result = Solver.ParseArray(data);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void ParseArray_Should_ParseSampleData3()
        {
            // Arrange
            string[] data =
            {
"*** ***   * *** ***   *",
"*   * *   * * *   *   *",
"*** * *   * *** ***   *",
"  * * *   *   * *     *",
"*** ***   * *** ***   *"
            };
            const int expected = 501921;

            // Act
            var result = Solver.ParseArray(data);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseArray_Should_ParseSampleData4()
        {
            // Arrange
            string[] data =
            {
"*** *** *** * * ***",
"  *   *   * * * * *",
"***   * *** *** ***",
"*     *   *   * * *",
"***   * ***   * ***"
            };
            const int expected = 27348;

            // Act
            var result = Solver.ParseArray(data);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseArray_Should_ParseSampleData5()
        {
            // Arrange
            string[] data =
            {
"***   * *** *** * * *** *** *** *** ***",
"* *   *   *   * * * *   *     * * * * *",
"* *   * *** *** *** *** ***   * *** ***",
"* *   * *     *   *   * * *   * * *   *",
"***   * *** ***   * *** ***   * *** ***"
            };
            const int expected = 0123456789;

            // Act
            var result = Solver.ParseArray(data);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
