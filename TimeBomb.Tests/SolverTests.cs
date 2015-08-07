using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeBomb.Tests
{
    [TestClass]
    public class SolverTests
    {
        [TestMethod]
        public void ParseArray_Should_ParseSampleData1()
        {
            // Arrange
            var testFiles = Directory.GetFiles("./data/", "*.in");

            foreach (var testFile in testFiles)
            {
                string expectedResponse = File.ReadAllText(testFile.Replace(".in", ".ans")).Trim();
                string[] testData = File.ReadAllLines(testFile);

                // Act
                var result = Solver.Solve(testData);

                // Assert
                Assert.AreEqual(expectedResponse, result, "Failed for " + Path.GetFileName(testFile));
                Console.WriteLine("Worked for: {0}", Path.GetFileName(testFile));
            }
        }
    }
}
